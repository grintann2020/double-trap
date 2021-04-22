using System;
using T;

namespace DT {

    public enum EPgm : byte {
        Init, Launch, Menu, Stg, Map
    }

    public class PgmPrm : IPgmPrm {

        public IPgm[] IPgmArr { get { return _iPgmArr; } }
        private IPgm[] _iPgmArr = new IPgm[Enum.GetNames(typeof(EPgm)).Length];

        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LnchPgm _launchPgm = new LnchPgm(); // Launch Program
        private FstPgm _menuPgm = new FstPgm(); // Menu Program
        private StgPgm _stgPgm = new StgPgm(); // Stage Program
        private MapPgm _mapPgm = new MapPgm(); // Map Program

        public PgmPrm() {
            _iPgmArr[(byte)EPgm.Init] = _initPgm;
            _iPgmArr[(byte)EPgm.Launch] = _launchPgm;
            _iPgmArr[(byte)EPgm.Menu] = _menuPgm;
            _iPgmArr[(byte)EPgm.Stg] = _stgPgm;
            _iPgmArr[(byte)EPgm.Map] = _mapPgm;

            _initPgm.Next = _launchPgm;
            _launchPgm.Next = _menuPgm;
            _menuPgm.Next = null;
            _stgPgm.Next = _menuPgm;
        }
    }
}