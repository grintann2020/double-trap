using System;
using UnityEngine;
using T;

namespace DT {

    public class MusII : II, III {

        public enum EDtc : byte {
            I0, I1
        }

        public MusII() {
            _dDtcArr = new _dDtc[Enum.GetNames(typeof(EDtc)).Length];
            _dDtcArr[(byte)EDtc.I0] = I0;
            _dDtcArr[(byte)EDtc.I1] = I1;
        }

        private void I0(Action rct) {
            if (Input.GetMouseButtonDown(0)) {
                Debug.Log("Pressed left click.");
                rct();
            }
            if (Input.GetMouseButtonDown(1)) {
                Debug.Log("Pressed right click.");
                rct();
            }
        }

        private void I1(Action rct) {
            if (Input.GetMouseButtonDown(2)) {
                Debug.Log("Pressed middle click.");
                rct();
            }
        }
    }
}