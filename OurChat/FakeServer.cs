using NetMQ;
using NetMQ.Sockets;
using OurChat.Messaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OurChat {
    public class FakeServer {
        public void Init() {
            bool working = true;
            var server = new ResponseSocket(); server.Bind("tcp://localhost:12553");
            Msg msg = new Msg(); 
            while (working) {
                msg.InitEmpty();
                server.Receive(ref msg);
                Message message = Message.Deserialize(msg.Data);
                if (message.MessageType.HasFlag(MessageType.MT_MEMBER_FLAG)) {
                    MessageType mt = message.MessageType & MessageType.MT_MEMBER_FLAG_MASK;
                    switch (mt) {
                        case MessageType.MT_MEMBER_INFO:
                            Msg reply = new Msg();
                            string guid = Encoding.Default.GetString(message.Content);
                            Guid g = Guid.Parse(guid);
                            Membership membership = new Membership() {
                                ID = new Guid(12, 34, 56, 78, 90, 13, 24, 25, 06, 77, 88),
                                Name = "未来的风", NickName = "没有风",
                                LastLoginIP = 0x7F_00_00_01, SuccessfullyLoginCount = 0,
                                Department = new string[] { "1", "2", "3", "4" },
                                DepartmentInfo = "未见", DepartmentLevel = 4,
                                PortraitID = 1, CustomPortrait = null
                            };
                            using (MemoryStream ms = new MemoryStream()) {
                                BinaryFormatter bf = new BinaryFormatter();
                                bf.Serialize(ms, membership);
                                byte[] b = ms.ToArray();
                                Message Reply = new Message(1, message.To, message.From, Guid.Empty,
                                    TimeSpan.FromSeconds(1D), false, new Guid(),
                                    MessageType.MT_MEMBER_INFO_REPLY, b.Length, b);
                                b = Message.Serialize(Reply);
                                reply.InitPool(b.Length);
                                reply.Put(b, 0, b.Length);
                            };
                            server.TrySend(ref reply, TimeSpan.MaxValue, false);
                            break;
                        case MessageType.MT_MEMBER_NEW:
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
