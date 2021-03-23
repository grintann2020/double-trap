using T;

namespace Robot {

    public class PgmPrime : IPgmPrime {

        public PgmMgr Mgr { private get; set; }
        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LaunchPgm _launchPgm = new LaunchPgm(); // Launch Program

        public void Init() {
            Mgr.Reg((byte)EPgm.Init, _initPgm);
            Mgr.Reg((byte)EPgm.Launch, _launchPgm);
            Mgr.Link(_initPgm, _launchPgm);
            Mgr.Link(_launchPgm, null);
            
            Mgr.Exe((byte)EPgm.Init);
        }
    }
}