using NetMQ;
using NetMQ.Sockets;
using System;

namespace OurChat {
    [Obsolete]
    public class ServerDealingEngine<T, U> where T : class where U : class {
        private Msg msg;
        private ResponseSocket server;

        private ServerDealingEngine() { }

        public ServerDealingEngine(ResponseSocket server) {
            this.server = server;
        }

        public Func<T, bool> PreChecker { get; set; }
        public Func<T, U, bool> Dealer { get; set; }
        public Func<U, bool> PostChecker { get; set; }
    }

    [Obsolete]
    public interface IServerDealer {
        bool PreChecker();
        bool Dealer();
        bool PostChecker();
    }

    [Obsolete]
    public class MemberInfoDealer : IServerDealer {
        public bool PreChecker() { return false; }
        public bool Dealer() { return false; }
        public bool PostChecker() { return false; }
    }
}