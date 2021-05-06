namespace T {

    public class Stg {

        protected delegate void _dBgn();
        protected delegate void _dUpd();
        protected delegate bool _dCond();
        protected _dBgn[] _dBgnArr;
        protected _dUpd[] _dUpdArr;
        protected _dCond[] _dCondArr;
        protected byte[][][] _prcsArr;
        protected byte _ePrcs;
        protected bool _isImp;
        protected const byte PR = 2;

        public Stg() {
            _ePrcs = 0;
            _isImp = false;
        }

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

        public virtual void Clr() {
            _ePrcs = 0;
            _isImp = false;
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