using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurChat.Messaging {
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum MessageType {
        MT_NOP = 0x0000_0000,
        MT_PLAINTEXT = 0x0000_0001,
        MT_IMAGE = 0x0000_0002,
        MT_GIF = 0x0000_0003,
        MT_RICHTEXT = 0x0000_0004,
        MT_URL = 0x0000_0005,

        MT_CODE_FLAG = 0x0000_1000,
        MT_CODE_C = 0x0000_0000,
        MT_CODE_CPP = 0x0000_0001,
        MT_CODE_CSHARP = 0x0000_0002,
        MT_CODE_JAVA = 0x0000_0FFF,
        MT_CODE_SHELL = 0x0000_0003,
        MT_CODE_PYTHON = 0x0000_0004,

        MT_MEMBER_FLAG = 0x0000_2000,
        MT_MEMBER_FLAG_MASK = 0x0000_0FFF,

        MT_MEMBER_INVITE = 0x0000_0001,
        MT_MEMBER_INVITE_REPLY = 0x0000_0002,
        MT_MEMBER_REMOVE = 0x0000_0003,
        MT_MEMBER_REMOVE_REPLY = 0x0000_0004,
        MT_MEMBER_GROUP_MODIFY = 0x0000_0005,
        MT_MEMBER_INFO = 0x0000_0007,
        MT_MEMBER_INFO_REPLY = 0x0000_0008,
        MT_MEMBER_LIST = 0x0000_0006,
        MT_MEMBER_LOGIN = 0x0000_0009,
        MT_MEMBER_LOGOUT = 0x0000_000A,
        MT_MEMBER_NEW = 0x0000_000B,
        MT_MEMBER_NEW_REPLY = 0x0000_000C,
        MT_MEMBER_QUERY = 0x0000_000D,
        MT_MEMBER_QUERY_REPLY = 0x0000_000E,


        MT_GROUP_FLAG = 0x4000_0000,
    }
}
