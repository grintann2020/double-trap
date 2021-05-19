namespace T {

    public class IaMgr : Sgltn<IaMgr> {

        private IIa[] _iIaArr;
        private IIa _iCurIa;

        public void Bind(IIaPrm iIaPrm) {
            _iIaArr = iIaPrm.IIaArr;
        }

        public void Init() {
            _iCurIa = null;
        }

        public void Instl(byte eIa) {
            if (_iCurIa != null) {
                if (_iIaArr[eIa] == _iCurIa) {
                    return;
                }
                _iCurIa.Unstl();
            }
            _iCurIa = _iIaArr[eIa];
            _iCurIa.Instl();
        }

        public void Unstl(byte eIa) {
            if (_iCurIa != null) {
                _iCurIa.Unstl();
                _iCurIa = null;
            }
        }

        public void InvkUpd() {
            if (_iCurIa != null) {
                _iCurIa.InvkUpd();
            }
        }

        public IIa Ia(byte eIa) {
            return _iIaArr[eIa];
        }

        public bool IsInstl(byte eIa) {
            return _iIaArr[eIa].IsInstl;
        }
    }
}