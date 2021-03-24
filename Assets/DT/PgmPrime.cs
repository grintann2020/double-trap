using System;
using T;

namespace DT {

    public enum EPgm : byte {
        Init, Launch, Menu, Stg, Map
    }

    public class PgmPrime : IPgmPrime {

        // public PgmMgr Mgr { private get; set; }
        public IPgm[] IArr { get { return _iArr; } }
        private IPgm[] _iArr;

        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LaunchPgm _launchPgm = new LaunchPgm(); // Launch Program
        private MenuPgm _menuPgm = new MenuPgm(); // Menu Program
        private StgPgm _stgPgm = new StgPgm(); // Stage Program
        private MapPgm _mapPgm = new MapPgm(); // Map Program

        public void Init() {
            _iArr = new IPgm[Enum.GetNames(typeof(EPgm)).Length];
            _iArr[(byte)EPgm.Init] = _initPgm;
            _iArr[(byte)EPgm.Launch] = _launchPgm;
            _iArr[(byte)EPgm.Menu] = _menuPgm;
            _iArr[(byte)EPgm.Stg] = _stgPgm;
            _iArr[(byte)EPgm.Map] = _mapPgm;
            
            _initPgm.Next = _launchPgm;
            _launchPgm.Next = _menuPgm;
            _menuPgm.Next = null;
            _stgPgm.Next = _menuPgm;


            // _iArr[(byte)EPgm.Init] = new InitPgm();
            // _iArr[(byte)EPgm.Launch] = new LaunchPgm();
            // _iArr[(byte)EPgm.Menu] = new MenuPgm();
            // _iArr[(byte)EPgm.Stg] = new StgPgm();
            // _iArr[(byte)EPgm.Map] = new MapPgm();

            // _iArr[(byte)EPgm.Init].Next = _iArr[(byte)EPgm.Launch];
            // _iArr[(byte)EPgm.Launch].Next = _iArr[(byte)EPgm.Menu];
            // _iArr[(byte)EPgm.Menu].Next = null;
            // _iArr[(byte)EPgm.Stg].Next = _iArr[(byte)EPgm.Stg];

            // Mgr.Reg(_iArr);
            // Mgr.Reg(new IPgm[] {
            //     _initPgm, _launchPgm, _menuPgm, _stgPgm, _mapPgm
            // });
            // Mgr.Reg((byte)EPgm.Init, _initPgm);
            // Mgr.Reg((byte)EPgm.Launch, _launchPgm);
            // Mgr.Reg((byte)EPgm.Menu, _menuPgm);
            // Mgr.Reg((byte)EPgm.Stg, _stgPgm);
            // Mgr.Link(_initPgm, _launchPgm);
            // Mgr.Link(_launchPgm, _menuPgm);
            // Mgr.Link(_menuPgm, null);
            // Mgr.Link(_stgPgm, _menuPgm);
            
            // Mgr.Exe((byte)EPgm.Init);
        }
    }
}