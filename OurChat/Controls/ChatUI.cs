using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OurChat {
    public partial class ChatUI : UserControl {
        //private List<Messaging.Message> messages = null;
        private Guid target;

        public Guid Target { get { return target; } }

        public ChatUI(Guid target) {
            InitializeComponent();

            this.target = target;

            SizeChanged += (sender, @event) => {
                foreach (Control c in flowLp.Controls) {
                    c.Width = Width - 8;
                }
            };
        }

        public void AddMessage(Guid portait, string rtxContent, bool portaitLeft = true) {
            Bubble bubble = new Bubble(portait, rtxContent, portaitLeft) {
                Width = Width - 8,
                Height = ((new Random()).Next() % 3 + 1) * 32,
            };
            flowLp.Controls.Add(bubble);
        }
    }
}
