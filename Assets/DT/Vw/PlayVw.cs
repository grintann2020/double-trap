using System;
using UnityEngine;
using T;

namespace DT {

    public class PlayVw : Vw, IVw {

        public enum EAct {
            P1, P2, P3
        }

        private _dAct[] _dActArr = new _dAct[Enum.GetNames(typeof(EAct)).Length];

        public PlayVw(SCamPrj defProj, SOrnt3 defOrnt) : base(defProj, defOrnt) {
            _dActArr[(byte)EAct.P1] = P1;
            _dActArr[(byte)EAct.P2] = P2;
        }

        public void InvkUpd() {

        }

        public void Act(byte act) {
            _dActArr[act].Invoke();
        }

        public void P1() {
            Debug.Log("PlayVw -- P1()");
        }

        public void P2() {
            Debug.Log("PlayVw -- P2()");
        }
    }
}