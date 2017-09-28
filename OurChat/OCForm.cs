﻿using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace OurChat {
    public partial class OCForm : Form {
        #region InteropServices/Win SDK
        [DllImport("user32.dll")]
        static extern IntPtr SetCapture(IntPtr/*long*/ hWnd);
        [DllImport("user32.dll")]
        static extern long ReleaseCapture();
        [DllImport("user32.dll")]
        static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        #endregion

        private ConcurrentQueue<Message> messages;

        private WindowsFormsSynchronizationContext sc = null;

        private ConcurrentDictionary<string, ChatUI> chatrooms = new ConcurrentDictionary<string, ChatUI>();

        private ConcurrentDictionary<string, Messaging.Membership> members = new ConcurrentDictionary<string, Messaging.Membership>();

        private ChatUI ActiveChatUI = null;

        private AutoResetEvent sendEvent = new AutoResetEvent(false);

        private Msg msg;

        //TODO:: Identify ME!
        private Guid from;

        public OCForm() {
            sc = WindowsFormsSynchronizationContext.Current as WindowsFormsSynchronizationContext;

            InitializeComponent();

            flowLayoutPanelSysmenu.MouseDown += MoveWindow;
            toolStripLeftPanel.MouseDown += MoveWindow;

            RegisterSysCommandBehavior();

            RegisterOwnerDraw();

            lvConversations.Items.AddRange(new ListViewItem[] {
                new ListViewItem("1"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="姓名1", LastUpdate = DateTime.Now, PeekMessage = "Message1", IsMute = true } },
                new ListViewItem("2"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="Name2", LastUpdate = DateTime.Now, PeekMessage = "\ue136", IsMute = true } },
                new ListViewItem("3"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="Name3", LastUpdate = DateTime.Now, PeekMessage = "消息～3", IsMute = true } },
                new ListViewItem("1"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="姓名1", LastUpdate = DateTime.Now, PeekMessage = "Message1", IsMute = true } },
                new ListViewItem("2"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="Name2", LastUpdate = DateTime.Now, PeekMessage = "\ue137", IsMute = true } },
                new ListViewItem("3"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="Name3", LastUpdate = DateTime.Now, PeekMessage = "消息～3", IsMute = true } },
                new ListViewItem("1"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="姓名1", LastUpdate = DateTime.Now, PeekMessage = "Message1", IsMute = true } },
                new ListViewItem("2"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="Name2", LastUpdate = DateTime.Now, PeekMessage = "Message2", IsMute = true } },
                new ListViewItem("3"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="Name3", LastUpdate = DateTime.Now, PeekMessage = "消息～3", IsMute = true } },
                new ListViewItem("1"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="姓名1", LastUpdate = DateTime.Now, PeekMessage = "\ue138", IsMute = true } },
                new ListViewItem("2"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="Name2", LastUpdate = DateTime.Now, PeekMessage = "Message2", IsMute = true } },
                new ListViewItem("3"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="Name3", LastUpdate = DateTime.Now, PeekMessage = "消息～3", IsMute = true } },
                new ListViewItem("1"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="姓名1", LastUpdate = DateTime.Now, PeekMessage = "Message1", IsMute = true } },
                new ListViewItem("2"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="Name2", LastUpdate = DateTime.Now, PeekMessage = "\ue139", IsMute = true } },
                new ListViewItem("3"){Tag = new ConversationShortcut(){Icon = Guid.NewGuid(), DisplayName="Name3", LastUpdate = DateTime.Now, PeekMessage = "消息～3", IsMute = true } },
            });

            chatUI.AddMessage(Guid.Empty, "你好,祝你生日快乐!");
            chatUI.AddMessage(Guid.Empty, "你是？", false);
            chatUI.AddMessage(Guid.Empty, "我是你的小号啊");
            chatUI.AddMessage(Guid.Empty, ":-( 伐开熏 ...", false);

            Messaging.Message message = null;
            ThreadPool.QueueUserWorkItem(state => {
                //Get Message From 0MQ
                //Handle
                bool working = true;
                while (working) {
                    sendEvent.WaitOne();
                    //Validate Message;
                    if (message != null) {
                        Guid guid = message.From; string Guid = guid.ToString();
                        ChatUI ui = null;
                        if (chatrooms.ContainsKey(Guid)) {
                            ui = chatrooms[Guid];
                        } else {
                            ui = new ChatUI(guid); chatrooms.TryAdd(Guid, ui);
                        }
                    }
                }
            });

            ThreadPool.QueueUserWorkItem(state => {
                SubscriberSocket subscriber = null;
                //Handle Subscriber
                subscriber.SubscribeToAnyTopic();
                Msg msg = new Msg();
                while (true) {
                    subscriber.TryReceive(ref msg, TimeSpan.MaxValue);
                    using (MemoryStream ms = new MemoryStream(msg.Data)) {
                        BinaryFormatter bf = new BinaryFormatter();
                        Messaging.Message groupMessage = bf.Deserialize(ms) as Messaging.Message;
                        if (groupMessage == null) continue;
                        if (!groupMessage.MessageType.HasFlag(Messaging.MessageType.MT_GROUP_FLAG)) continue;
                        Guid from = groupMessage.From;
                    }
                }
            });

            cmdSend.Click += (sender, @event) => {
                if (ActiveChatUI == null) return;

                Guid TO = ActiveChatUI.Target; string to = TO.ToString();
                if (!members.ContainsKey(to)) return;
                using (var client = new RequestSocket()) {
                    Messaging.Membership membership = members[to];
                    client.Connect($">tcp://0x{membership.LastLoginIP:X}:12553");
                    string ____ = "-------------------";
                    byte[] data = Encoding.UTF8.GetBytes(____);
                    Messaging.Message m = new Messaging.Message(1, from, TO, Guid.Empty, TimeSpan.FromMinutes(1D), false, new Guid(), Messaging.MessageType.MT_PLAINTEXT, data.Length, data);
                    using (MemoryStream ms = new MemoryStream()) {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(ms, m); data = ms.ToArray();
                        msg.Put(data, 0, data.Length);
                    }
                    client.Send(ref msg, false);
                    sendEvent.Set();
                }
            };
        }

        private void MoveWindow(object sender, MouseEventArgs e) {
            if (WindowState == FormWindowState.Maximized) return;
            ReleaseCapture();
            SendMessage(Handle, 0x0112, 0xF012, 0);
        }

        private void LoadLeftPanel() {
            //Portrit
        }

        private void RegisterSysCommandBehavior() {
            sysCmdPin.Click += (sender, @event) => {
                TopMost = !TopMost;
                sysCmdPin.Text = TopMost ? "p" : "`";
            };

            sysCmdMinimize.Click += (sender, @event) => {
                WindowState = FormWindowState.Minimized;
            };

            sysCmdMaximize.Click += (sender, @event) => {
                switch (WindowState) {
                    case FormWindowState.Minimized:
                    case FormWindowState.Normal:
                        WindowState = FormWindowState.Maximized;
                        break;
                    case FormWindowState.Maximized:
                        WindowState = FormWindowState.Normal;
                        break;
                }
            };

            sysCmdClose.Click += (sender, @event) => {
                Close();
            };
        }

        private void RegisterOwnerDraw() {
            lvConversations.DrawItem += (sender, @event) => {
                ListView @this = @event.Item.ListView;
                var lvi = @event.Item; var cs = lvi.Tag as ConversationShortcut;
                if (lvi.Selected) @event.Graphics.FillRectangle(Brushes.DarkGray, lvi.Bounds);
                string guid = cs.Icon.ToString();
                Icon icon = Utilities.IconCache.Find(guid);
                if (icon == null) icon = Icon.ExtractAssociatedIcon(@"D:\desktop\s.bat");
                @event.Graphics.DrawIcon(icon, @event.Bounds.X, @event.Bounds.Y + 8);
                @event.Graphics.DrawString(cs.DisplayName, lvConversations.Font, Brushes.Black, @event.Bounds.X + 32, @event.Bounds.Y);
                @event.Graphics.DrawString(cs.LastUpdate.ToShortTimeString(), lvConversations.Font, Brushes.Gray, @event.Bounds.X + 164, @event.Bounds.Y);
                @event.Graphics.DrawString(cs.PeekMessage, lvConversations.Font, Brushes.Gray, @event.Bounds.X + 32, @event.Bounds.Y + 22);
                @event.Graphics.DrawString(cs.IsMute.ToString(), lvConversations.Font, Brushes.Gray, @event.Bounds.X + 164, @event.Bounds.Y + 22);
            };

            #region Detail
            lvConversations.DrawSubItem += (sender, @event) => {
                ListView @this = @event.Item.ListView;
                var lvi = @event.Item;
                switch (@event.ColumnIndex) {
                    case 0://Icon
                        string guid = lvi.Text;
                        Icon icon = Utilities.IconCache.Find(guid);
                        if (icon == null) icon = Icon.ExtractAssociatedIcon(@"D:\desktop\s.bat");
                        @event.Graphics.DrawIcon(icon, @event.Bounds);
                        break;
                    case 1://DisplayName
                        @event.Graphics.DrawString(lvi.SubItems[1].Text, lvConversations.Font, Brushes.Black, @event.Bounds.X + 32, @event.Bounds.Y);
                        break;
                    case 2://LastUpdate
                        @event.Graphics.DrawString(lvi.SubItems[2].Text, lvConversations.Font, Brushes.Gray, @event.Bounds.X + 64, @event.Bounds.Y);
                        break;
                    case 3://PeekMessage
                        @event.Graphics.DrawString(lvi.SubItems[3].Text, lvConversations.Font, Brushes.Black, @event.Bounds.X + 32, @event.Bounds.Y + 32);
                        break;
                    case 4://IsMute
                        @event.Graphics.DrawString(lvi.SubItems[4].Text, lvConversations.Font, Brushes.Black, @event.Bounds.X + 64, @event.Bounds.Y + 64);
                        break;
                }
            };
            #endregion
        }
    }
}