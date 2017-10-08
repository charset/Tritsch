using OurChat.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurChat.Messaging {
    public class MessageFactory {
        public static Message CreateMemberInfoMessage(Guid from , Guid to, byte[] content) {
            return new Message(1, from, to, Guid.Empty, TimeSpan.MaxValue, false, new Guid(), MessageType.MT_MEMBER_INFO | MessageType.MT_MEMBER_FLAG, content.Length, content);
        }
        public static Message CreateMemberInfoMessage(Guid from ,Guid to, Guid who) {
            MemberInfoRequest request = new MemberInfoRequest() { Guid = who.ToString() };
            byte[] b = SerializerUtil<MemberInfoRequest>.Serialize(request);
            return CreateMemberInfoMessage(from, to, b);
        }
        public static Message CreateMemberInfoRespMessage(Guid from, Guid to, byte[] content) {
            return new Message(1, from, to, Guid.Empty, TimeSpan.MaxValue, false, new Guid(), MessageType.MT_MEMBER_INFO_REPLY | MessageType.MT_MEMBER_FLAG, content.Length, content);
        }
        public static Message CreateMemberInfoRespMessage(Guid from, Guid to, Membership membership) {
            MemberInfoResponse response = new MemberInfoResponse() { ErrorCode = "SUCCESS", Prompt = string.Empty, Membership = membership };
            byte[] b = SerializerUtil<MemberInfoResponse>.Serialize(response);
            return CreateMemberInfoRespMessage(from, to, b);
        }
        public static Message CreateMemberQueryRespMessage(Guid from, Guid to, byte[] content) {
            return new Message(1, from, to, Guid.Empty, TimeSpan.MaxValue, false, new Guid(), MessageType.MT_MEMBER_QUERY_REPLY | MessageType.MT_MEMBER_FLAG, content.Length, content);
        }
        public static Message CreateMemberQueryRespMessage(Guid from, Guid to, List<Membership> members) {
            MemberQueryResponse response = new MemberQueryResponse() { ErrorCode = "SUCCESS", Prompt = string.Empty, Members = members };
            byte[] b = SerializerUtil<MemberQueryResponse>.Serialize(response);
            return CreateMemberQueryRespMessage(from, to, b);
        }
    }
}
