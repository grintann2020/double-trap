using System;
using UnityEngine;
using T;

namespace DT {

    public class A0Ia : Ia, IIa {

        public enum ERct {
            R0, R1
        }

        public enum EEvt {
            E0, E1, E2
        }

        private byte _r0, _r1 = 0;

        public A0Ia(III[] iIIPrmArr) : base(iIIPrmArr) {
            _iIIArr = new III[2] { _iIIPrmArr[(byte)EII.Mus], _iIIPrmArr[(byte)EII.KB] };

            _rctArr = new Action[Enum.GetNames(typeof(ERct)).Length];
            _rctArr[(byte)ERct.R0] = R0;
            _rctArr[(byte)ERct.R1] = R1;

            _evtArr = new byte[Enum.GetNames(typeof(EEvt)).Length][];
            _evtArr[(byte)EEvt.E0] = new byte[PR] { 0, (byte)MusII.EDtc.I0, (byte)ERct.R0 };
            _evtArr[(byte)EEvt.E1] = new byte[PR] { 0, (byte)MusII.EDtc.I1, (byte)ERct.R0 };
            _evtArr[(byte)EEvt.E2] = new byte[PR] { 0, (byte)MusII.EDtc.I1, (byte)ERct.R1 };
        }

        public void R0() {
            _r0 += 1;
            Debug.Log("A0Ia R0() -- " + _r0);
        }

        public void R1() {
            _r1 += 1;
            Debug.Log("A0Ia R1() -- " + _r1);
        }
    }
}