using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OurChat.Messaging {
    [Serializable]
    public sealed class Message {
        /// <summary>
        /// 版本号, 会影响到默认的Message解析函数
        /// </summary>
        public readonly int Version;
        /// <summary>
        /// 发件人
        /// </summary>
        public readonly Guid From;
        /// <summary>
        /// 收件人
        /// </summary>
        public readonly Guid To;
        /// <summary>
        /// 上个中转人
        /// </summary>
        public readonly Guid Proxy;
        /// <summary>
        /// 发送时间
        /// </summary>
        public readonly DateTime Created;
        /// <summary>
        /// 过期时间
        /// </summary>
        public readonly TimeSpan Expired;
        /// <summary>
        /// 需要回执
        /// </summary>
        public readonly bool ReceptRequired;
        /// <summary>
        /// 消息号
        /// </summary>
        public readonly Guid MessageID;
        /// <summary>
        /// 消息类型
        /// </summary>
        public readonly MessageType MessageType;
        /// <summary>
        /// 消息长度
        /// </summary>
        public readonly Int32 Length;
        /// <summary>
        /// 内容
        /// </summary>
        public readonly byte[] Content;

        private Message() { }

        public Message(int version, Guid from, Guid to, Guid proxy, TimeSpan expired, bool receptRequired, Guid messageID, 
            MessageType messageType, int length, byte[] content) {
            Version = version; From = from; To = to; Proxy = proxy;
            Expired = expired; ReceptRequired = receptRequired;
            MessageID = messageID; MessageType = messageType;
            Length = length; Content = content;
            Created = DateTime.Now;
        }

        private static BinaryFormatter bf = new BinaryFormatter();
        public static Message Deserialize(byte[] b) {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(b)) {
                return bf.Deserialize(ms) as Message;
            }
        }

        public static byte[] Serialize(Message message) {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream()) {
                bf.Serialize(ms, message);
                return ms.ToArray();
            }
        }
    }
}
