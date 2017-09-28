using System;

namespace OurChat {
    /// <summary>
    /// 本类代表会话窗口中显示的细节
    /// </summary>
    public sealed class ConversationShortcut {
        public Guid Icon { get; set; }
        public string DisplayName { get; set; }
        public DateTime LastUpdate { get; set; }
        public string PeekMessage { get; set; }
        public bool IsMute { get; set; }
        public bool NewMessage { get; set; }
    }
}
