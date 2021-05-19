using System;
using T;

namespace DT {

    public class KBII : II, III {

        public enum EDtc : byte {
            A0, A1, A2
        }

        public KBII() {
            _dDtcArr = new _dDtc[Enum.GetNames(typeof(EDtc)).Length];
            _dDtcArr[(byte)EDtc.A0] = A0;
            _dDtcArr[(byte)EDtc.A1] = A1;
            _dDtcArr[(byte)EDtc.A2] = A2;
        }

        private void A0(Action dRct) {
        }

        private void A1(Action dRct) {
        }

        private void A2(Action dRct) {
        }
    }
}