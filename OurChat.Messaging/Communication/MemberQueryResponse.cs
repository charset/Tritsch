using OurChat.Messaging;
using System;
using System.Collections.Generic;

namespace OurChat.Communication {
    [Serializable]
    public class MemberQueryResponse {
        public string ErrorCode { get; set; }
        public string Prompt { get; set; }

        public List<Membership> Members { get; set; }
    }
}
