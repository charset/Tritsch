using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurChat.Utilities {
    public class IconCache {
        protected static Dictionary<string, Icon> cache = new Dictionary<string, Icon>();

        public static void Add(string name , Icon icon) {
            if (!Guid.TryParse(name, out Guid result)) return;
            if (!cache.ContainsKey(name)) cache.Add(name, icon);
        }

        public static Icon Find(string name) {
            if (!cache.ContainsKey(name)) return null;
            return cache[name];
        }
    }
}
