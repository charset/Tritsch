using System.Runtime.Serialization.Formatters.Binary;

namespace OurChat {
    public static class SerializerUtil<T> where T : class {
        private static BinaryFormatter bf = new BinaryFormatter();
        public static byte[] Serialize(T t) {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream()) {
                bf.Serialize(ms, t);
                return ms.ToArray();
            }
        }
        public static T Deserialize(byte[] b) {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(b)) {
                return bf.Deserialize(ms) as T;
            }
        }
    }
}