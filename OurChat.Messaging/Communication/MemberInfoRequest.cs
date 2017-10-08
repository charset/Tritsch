using System;

namespace OurChat.Communication {
    [Serializable]
    public class MemberInfoRequest {
        public string Guid { get; set; }
    }
}