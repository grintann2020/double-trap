using System;
using T;

namespace DT {

    public enum EPgm : byte {
        Init, Launch, Menu, Stg, Map
    }

    public class PgmPrime : IPgmPrime {

        public IPgm[] IPgmArr { get { return _iPgmArr; } }
        private IPgm[] _iPgmArr = new IPgm[Enum.GetNames(typeof(EPgm)).Length];
        // program objects
        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LaunchPgm _launchPgm = new LaunchPgm(); // Launch Program
        private MenuPgm _menuPgm = new MenuPgm(); // Menu Program
        private StgPgm _stgPgm = new StgPgm(); // Stage Program
        private MapPgm _mapPgm = new MapPgm(); // Map Program

        public PgmPrime() {
            _iPgmArr[(byte)EPgm.Init] = _initPgm;
            _iPgmArr[(byte)EPgm.Launch] = _launchPgm;
            _iPgmArr[(byte)EPgm.Menu] = _menuPgm;
            _iPgmArr[(byte)EPgm.Stg] = _stgPgm;
            _iPgmArr[(byte)EPgm.Map] = _mapPgm;
            // link settings
            _initPgm.Next = _launchPgm;
            _launchPgm.Next = _menuPgm;
            _menuPgm.Next = null;
            _stgPgm.Next = _menuPgm;
        }
    }
}