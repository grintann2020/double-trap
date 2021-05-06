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

        public void InvkUpd() {
            if (_iCurIa != null) {
                _iCurIa.InvkUpd();
            }
        }

        public void Sw(byte eIa) {
            if (_iCurIa != null) {
                if (_iIaArr[eIa] == _iCurIa) {
                    return;
                }
                _iCurIa = _iIaArr[eIa];
            }
        }
    }
}