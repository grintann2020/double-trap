namespace T {

    public class SpcMgr : Singleton<SpcMgr> {

        private ISpc[] _iSpcArr;
        private ISpc _iCurrSpc;

        public void Bind(ISpcPrm iSpcPrm) {
            _iSpcArr = iSpcPrm.ISpcArr;
        }

        public void Init() {
            _iCurrSpc = null;
        }

        public void Constr(byte eSpc) { // excute specific program by Enum
            if (_iCurrSpc != null) {
                if (_iSpcArr[eSpc] == _iCurrSpc) {
                    return;
                }
                _iCurrSpc.Elim();
            }
            _iCurrSpc = _iSpcArr[eSpc];
            _iCurrSpc.Constr();
        }
    }
}