using System;

namespace T {

    public class Ia {

        public bool IsInstl { get { return _isInstl; } }
        protected III[] _iIIPrmArr;
        protected III[] _iIIArr;
        protected Action[] _rctArr;
        protected byte[][] _evtArr;
        protected const byte PR = 3;
        private bool _isInstl;

        public Ia(III[] iIIPrmArr) {
            _iIIPrmArr = iIIPrmArr;
        }

        public virtual void Instl() {
            for (byte i = 0; i < _iIIArr.Length; i++) {
                _iIIArr[i].Instl();
            }
            for (byte e = 0; e < _evtArr.Length; e++) {
                _iIIArr[_evtArr[e][0]].Invk(_evtArr[e][1], _rctArr[_evtArr[e][2]]);
            }
            _isInstl = true;
        }

        public virtual void Unstl() {
            for (byte e = 0; e < _evtArr.Length; e++) {
                _iIIArr[_evtArr[e][0]].Waiv(_evtArr[e][1], _rctArr[_evtArr[e][2]]);
            }
            for (byte i = 0; i < _iIIArr.Length; i++) {
                _iIIArr[i].Unstl();
            }
            _isInstl = false;
        }

        public void InvkUpd() {
            if (_isInstl == false) {
                return;
            }
            for (byte i = 0; i < _iIIArr.Length; i++) {
                _iIIArr[i].InvkUpd();
            }
        }
    }
}