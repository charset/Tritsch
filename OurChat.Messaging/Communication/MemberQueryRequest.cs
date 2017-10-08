using System;
using System.Collections.Generic;

namespace OurChat.Communication {
    [Serializable]
    public class MemberQueryRequest {
        public string Name { get; set; }
        public List<string> Department { get; set; }
        public string NickName { get; set; }
    }
}
