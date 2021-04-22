namespace T {

    public class StgMgr : Sgltn<StgMgr> {

        private IStg[] _iStgArr;
        private IStg _iCurrStg;

        public void Bind(IStgPrm iStgPrm) {
            _iStgArr = iStgPrm.IStgArr;
        }

        public void Init() {
            _iCurrStg = null;
        }

        public void Imp(byte eStg) { // excute specific program by Enum
            if (_iCurrStg != null) {
                if (_iStgArr[eStg] == _iCurrStg) {
                    return;
                }
                _iCurrStg.Clr();
            }
            _iCurrStg = _iStgArr[eStg];
            _iCurrStg.Imp();
        }
    }
}