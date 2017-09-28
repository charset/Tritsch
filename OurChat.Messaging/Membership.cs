using System;
using System.Drawing;

namespace OurChat.Messaging {
    public class Membership {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int DepartmentLevel { get; set; }
        public string[] Department { get; set; }
        public string DepartmentInfo { get; set; }

        public UInt32 LastLoginIP { get; set; }
        public int SuccessfullyLoginCount { get; set; }
        public Bitmap Portrait { get; set; }
        public string NickName { get; set; }
    }
}
