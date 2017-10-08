using OurChat.Messaging;
using System;

namespace OurChat.Communication {
    [Serializable]
    public class MemberInfoResponse {
        public string ErrorCode { get; set; }
        public string Prompt { get; set; }

        public Membership Membership { get; set; }
    }
}