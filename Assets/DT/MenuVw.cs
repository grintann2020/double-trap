using System;
using UnityEngine;
using T;

namespace DT {

    public class MenuVw : Vw, IVw {

        private _dAct[] _dActArr = new _dAct[Enum.GetNames(typeof(EAct)).Length];

        public enum EAct {
            Test, GG, ok
        }

        public MenuVw() {
            _defOrnt = new SOrntC3(new SCoord3(20.0f, 20.0f, 20.0f), new SCoord3(0.0f, 0.0f, 0.0f));
            _dActArr[(byte)EAct.Test] = Test;
            _dActArr[(byte)EAct.GG] = GG;
        }

        public void InvkUpd() {

        }

        public void Act(byte act) {
            _dActArr[act].Invoke();
        }

        public void Test() {
            Debug.Log("MenuVw -- Test()");
        }

        public void GG() {
            Debug.Log("MenuVw -- GG()");
        }
    }
}