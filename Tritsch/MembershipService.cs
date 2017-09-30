using NetMQ;
using NetMQ.Sockets;
using OurChat.Messaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Tritsch {
    /// <summary>
    /// 针对Membership提供增删改查服务
    /// </summary>
    public partial class MembershipService : ServiceBase {
        public MembershipService() {
            InitializeComponent();
        }

        protected override void OnStart(string[] args) {

        }

        protected override void OnStop() {
        }
    }
}
