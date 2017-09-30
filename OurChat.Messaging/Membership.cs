using System;
using System.Drawing;

namespace OurChat.Messaging {
    [Serializable]
    public class Membership {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int DepartmentLevel { get; set; }
        public string[] Department { get; set; }
        public string DepartmentInfo { get; set; }

        public UInt32 LastLoginIP { get; set; }
        public int SuccessfullyLoginCount { get; set; }
        public int PortraitID { get; set; }
        public byte[] CustomPortrait { get; set; }
        public string NickName { get; set; }
    }
}
