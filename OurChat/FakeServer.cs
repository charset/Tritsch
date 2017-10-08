using NetMQ;
using NetMQ.Sockets;
using OurChat.Communication;
using OurChat.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OurChat {
    public class FakeServer {
        private ResponseSocket server = new ResponseSocket();
        private Dictionary<MessageType, Action<Message>> dealer = new Dictionary<MessageType, Action<Message>>();
        private Dictionary<string, Membership> members = new Dictionary<string, Membership>();
        private Dictionary<string, Group>
        private Msg requestMsg = new Msg();
        private Msg responseMsg = new Msg();

        public FakeServer() {//Register Dealer
            dealer.Add(MessageType.MT_MEMBER_INFO, ProcessMemberInfo);
            dealer.Add(MessageType.MT_MEMBER_QUERY, ProcessMemberQuery);
        }

        private void ProcessMemberInfo(Message message) {
            MemberInfoRequest request = SerializerUtil<MemberInfoRequest>.Deserialize(message.Content);
            //Find Member
            Membership membership = new Membership() {
                ID = new Guid(12, 34, 56, 78, 90, 13, 24, 25, 06, 77, 88),
                Name = "未来的风", NickName = "没有风",
                LastLoginIP = 0x7F_00_00_01, SuccessfullyLoginCount = 0,
                Department = new string[] { "1", "2", "3", "4" },
                DepartmentInfo = "未见", DepartmentLevel = 4,
                PortraitID = 1, CustomPortrait = null
            };
            Message Reply = MessageFactory.CreateMemberInfoRespMessage(message.To, message.From, membership);
            byte[] b = SerializerUtil<Message>.Serialize(Reply);
            responseMsg.InitPool(b.Length); responseMsg.Put(b, 0, b.Length);
            server.Send(ref responseMsg, false);
        }

        private void ProcessMemberQuery(Message message) {
            MemberQueryRequest request = SerializerUtil<MemberQueryRequest>.Deserialize(message.Content);
            //Filter
            HashSet<Membership> members = new HashSet<Membership>();
            var linq = members.Where(q => {
                bool name = string.IsNullOrEmpty(request.Name) || q.Name.IndexOf(request.Name) > 0;
                bool nick = string.IsNullOrEmpty(request.NickName) || q.NickName.IndexOf(request.NickName) > 0;
                bool dept = request.Department == null || request.Department.Count == 0;
                bool _ept = true;
                if (!dept) {
                    for (int i = 0; i < Math.Min(request.Department.Count, q.Department.Length); i++) {
                        _ept = _ept && request.Department[i].IndexOf(q.Department[i]) >= 0;
                    }
                }
                return name && nick && (dept || _ept);
            }).ToList();
            Message Reply = MessageFactory.CreateMemberQueryRespMessage(message.To, message.From, linq);
            byte[] b = SerializerUtil<Message>.Serialize(Reply);
            responseMsg.InitPool(b.Length); responseMsg.Put(b, 0, b.Length);
            server.Send(ref responseMsg, false);
        }

        public void Init() {
            bool working = true;
            server.Bind("tcp://localhost:12553");

            while (working) {
                requestMsg.InitEmpty();
                server.Receive(ref requestMsg);
                Message message = Message.Deserialize(requestMsg.Data);
                if (message.MessageType.HasFlag(MessageType.MT_MEMBER_FLAG)) {
                    MessageType mt = message.MessageType & MessageType.MT_MEMBER_FLAG_MASK;
                    if (dealer.ContainsKey(mt)) dealer[mt](message); 
                }
            }
        }
    }
}
