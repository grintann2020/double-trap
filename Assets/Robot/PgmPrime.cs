using System;
using T;

namespace Robot {

    public enum EPgm : byte {
        Init, Launch
    }

    public class PgmPrime : IPgmPrime {

        public IPgm[] IPgmArr { get { return _iPgmArr; } }
        private IPgm[] _iPgmArr = new IPgm[Enum.GetNames(typeof(EPgm)).Length];
        // program objects
        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LaunchPgm _launchPgm = new LaunchPgm(); // Launch Program

        public PgmPrime() {
            _iPgmArr[(byte)EPgm.Init] = _initPgm;
            _iPgmArr[(byte)EPgm.Launch] = _launchPgm;
            // link settings
            _initPgm.Next = _launchPgm;
        }
    }
}