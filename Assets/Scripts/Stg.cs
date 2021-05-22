namespace T {

    public class Stg {

        public bool IsImp { get { return _isImp; } }
        protected delegate void _dBgn();
        protected delegate void _dUpd();
        protected delegate bool _dCond();
        protected _dBgn[] _dBgnArr;
        protected _dUpd[] _dUpdArr;
        protected _dCond[] _dCondArr;
        protected byte[][][] _prcsArr;
        protected const byte PR = 2;
        private bool _isImp = false;
        private byte _ePrcs = 0;

        public virtual void Imp() {
            _isImp = true;
            _ePrcs = 0;
            _dBgnArr[_ePrcs].Invoke();
        }

        public virtual void Imp(byte ePrcs) {
            _isImp = true;
            _ePrcs = ePrcs;
            _dBgnArr[_ePrcs].Invoke();
        }

        public virtual void Abt() {
            _isImp = false;
            _ePrcs = 0; 
        }

        public void InvkUpd() {
            if (_isImp == false) {
                return;
            }
            for (byte c = 0; c < _prcsArr[_ePrcs].Length; c++) {
                if (_dCondArr[_prcsArr[_ePrcs][c][0]].Invoke()) {
                    _ePrcs = _prcsArr[_ePrcs][c][1];
                    _dBgnArr[_ePrcs].Invoke();
                }
            }
            if (_dUpdArr[_ePrcs] != null) {
                _dUpdArr[_ePrcs].Invoke();
            }
        }
    }
}