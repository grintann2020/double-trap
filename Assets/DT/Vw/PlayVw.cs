using System;
using UnityEngine;
using T;

namespace DT {

    public class PlayVw : Vw, IVw {

        public enum EChg {
            P1, P2, P3
        }

        public PlayVw(SCamPrj defProj, SOrnt3 defOrnt) : base(defProj, defOrnt) {
            _dChgArr = new _dChg[Enum.GetNames(typeof(EChg)).Length];
            _dChgArr[(byte)EChg.P1] = P1;
            _dChgArr[(byte)EChg.P2] = P2;
        }

        public void InvkUpd() {

        }

        public void P1() {
            Debug.Log("PlayVw -- P1()");
        }

        public void P2() {
            Debug.Log("PlayVw -- P2()");
        }
    }
}