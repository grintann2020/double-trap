using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace T {

    public enum EPgm {
        Init, Menu, Launch, Act
    }

    public class PgmMgr : Singleton<PgmMgr> {

        private Dictionary<EPgm, IPgm> _pgmDic = new Dictionary<EPgm, IPgm>();
        private IPgm _currPgm = null;

        private InitPgm _initPgm = new InitPgm(); // Initialize Program
        private LaunchPgm _launchPgm = new LaunchPgm(); // Launch Program
        private MenuPgm _menuPgm = new MenuPgm(); // Menu Program
        private ActPgm _actPgm = new ActPgm(); // Action Program

        public void Init() {
            Reg(EPgm.Init, _initPgm);
            Reg(EPgm.Launch, _launchPgm);
            Reg(EPgm.Menu, _menuPgm);
            Reg(EPgm.Act, _actPgm);
            Link(_initPgm, _launchPgm);
            Link(_launchPgm, _menuPgm);
            Link(_menuPgm, null);
            Link(_actPgm, _menuPgm);
        }

        public void InvokeUpd() {
            if (_currPgm != null) {
                _currPgm.InvokeUpd();
            }
        }

        public void Reg(EPgm ePgm, IPgm iPgm) {
            _pgmDic.Add(ePgm, iPgm);
            iPgm.Bind(this);
        }

        public void Link(IPgm thisPgm, IPgm nextPgm) {
            thisPgm.Next = nextPgm;
        }

        public void Exe(EPgm ePgm) { // excute specific program by Enum 
            if (_currPgm != null) {
                _currPgm.End();
            }
            _currPgm = _pgmDic[ePgm];
            _currPgm.Exe();
        }

        public void Exe(IPgm iPgm) { // excute specific program by interface
            if (_currPgm != null) {
                _currPgm.End();
            }
            _currPgm = iPgm;
            _currPgm.Exe();
        }

        public void Next() { // end current program and excute next program
            if (_currPgm != null && _currPgm.Next != null) {
                _currPgm.End();
                _currPgm = _currPgm.Next;
                _currPgm.Exe();
            }
        }

        // public void Exe(IPgm iPgm) {
        //     iPgm.Exe();
        // }

        // public void EndPgm(EPgm ePgm) { // End Specific Pgm By Enum
        //     _currPgm = null;
        //     End(_pgmDic[ePgm]);
        // }

        // public void EndPgm(IPgm iPgm) { // End Specific Pgm
        //     _currPgm = null;
        //     End(iPgm);
        // }

        // public void End(IPgm iPgm) {
        //     iPgm.End();
        // }
    }
}