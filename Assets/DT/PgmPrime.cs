using System.Collections.Generic;
using UnityEngine;
using T;

namespace DT {

    public class PgmPrime : IPgmPrime {

        public PgmMgr Mgr { private get; set; }
        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LaunchPgm _launchPgm = new LaunchPgm(); // Launch Program
        private MenuPgm _menuPgm = new MenuPgm(); // Menu Program
        private StgPgm _stgPgm = new StgPgm(); // Stage Program
        private MapPgm _mapPgm = new MapPgm(); // Map Program

        public void Init() {
            Mgr.Reg((byte)EPgm.Init, _initPgm);
            Mgr.Reg((byte)EPgm.Launch, _launchPgm);
            Mgr.Reg((byte)EPgm.Menu, _menuPgm);
            Mgr.Reg((byte)EPgm.Stg, _stgPgm);
            Mgr.Link(_initPgm, _launchPgm);
            Mgr.Link(_launchPgm, _menuPgm);
            Mgr.Link(_menuPgm, null);
            Mgr.Link(_stgPgm, _menuPgm);
            
            Mgr.Exe((byte)EPgm.Init);
        }
    }
}