namespace T {

    public class StgMgr : Sgltn<StgMgr> {

        private IStg[] _iStgArr;
        private IStg _iCurStg;

        public void Bind(IStgPrm iStgPrm) {
            _iStgArr = iStgPrm.IStgArr;
        }

        public void Init() {
            _iCurStg = null;
        }

        public void Imp(byte eStg) { // excute specific program by Enum
            if (_iCurStg != null) {
                if (_iStgArr[eStg] == _iCurStg) {
                    return;
                }
                _iCurStg.Clr();
            }
            _iCurStg = _iStgArr[eStg];
            _iCurStg.Imp();
        }

        public void Clr(byte eStg) {
            if (_iCurStg != null) {
                _iCurStg.Clr();
                _iCurStg = null;
            }
        }
    }
}