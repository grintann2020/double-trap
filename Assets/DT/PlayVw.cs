using System;
using UnityEngine;
using T;

namespace DT {

    public class PlayVw : Vw, IVw {

        private _dAct[] _dActArr = new _dAct[Enum.GetNames(typeof(EAct)).Length];

        public enum EAct {
            P1, P2, P3
        }

        public PlayVw() {
            _defOrnt = new SOrntC3(new SCoord3(12.0f, 13.0f, 15.0f), new SCoord3(0.0f, 0.0f, 0.0f));
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