using System;
using T;

namespace Robot {

    public enum EPgm : byte {
        Init, Launch
    }

    public class PgmPrime : IPgmPrime {

        // public PgmMgr Mgr { private get; set; }
        public IPgm[] IArr { get { return _iArr; } }
        private IPgm[] _iArr;

        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LaunchPgm _launchPgm = new LaunchPgm(); // Launch Program

        public void Init() {
            _iArr = new IPgm[Enum.GetNames(typeof(EPgm)).Length];
            _iArr[(byte)EPgm.Init] = _initPgm;
            _iArr[(byte)EPgm.Launch] = _launchPgm;
            
            _initPgm.Next = _launchPgm;

        //     Mgr.Reg(new IPgm[] {
        //         _initPgm, _launchPgm
        //     });
        //     Mgr.Link(_initPgm, _launchPgm);
        //     Mgr.Link(_launchPgm, null);
            
        //     Mgr.Exe((byte)EPgm.Init);
        // }
    }
}