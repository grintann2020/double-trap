using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace T {

    public enum EPgm {
        Init, Menu
    }

    public class PgmMgr : Singleton<PgmMgr> {

        private Dictionary<EPgm, IPgm> _pgmDic = new Dictionary<EPgm, IPgm>();
        private IPgm _currPgm = null;

        private InitPgm _initPgm = new InitPgm(); // 初始化程序
        private MenuPgm _menuPgm = new MenuPgm(); // 啟動程序

        public void Init() {
            Register(EPgm.Init, _initPgm);
            Register(EPgm.Menu, _menuPgm);
            Link(_initPgm, _menuPgm);
            Link(_menuPgm, null);
        }

        public void InvokeUpd() {
            if (_currPgm != null) {
                _currPgm.InvokeUpd();
            }
        }

        public void Register(EPgm ePgm, IPgm iPgm) {
            _pgmDic.Add(ePgm, iPgm);
            iPgm.Bind(this);
        }

        public void Link(IPgm thisPgm, IPgm nextPgm) {
            thisPgm.Next = nextPgm;
        }

        public void ExePgm(EPgm ePgm) { // Excute Specific Pgm By Enum 
            _currPgm = _pgmDic[ePgm];
            ExePgm(_currPgm);
        }

        public void ExePgm(IPgm iPgm) { // Excute Specific Pgm
            _currPgm = iPgm;
            ExePgm(_currPgm);
        }

        public void Exe(IPgm iPgm) {
            iPgm.Exe();
        }

        public void EndPgm(EPgm ePgm) { // nd Specific Pgm By Enum
            _currPgm = null;
            End(_pgmDic[ePgm]);
        }

        public void EndPgm(IPgm iPgm) { // End Specific Pgm
            _currPgm = null;
            End(iPgm);
        }

        public void End(IPgm iPgm) {
            iPgm.End();
        }

        public void Next() { // End _currPgm And Excute Next Pgm
            if (_currPgm != null && _currPgm.Next != null) {
                _currPgm.End();
                _currPgm.Next.Exe();
                _currPgm = _currPgm.Next;
            }
        }
    }
}