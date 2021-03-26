namespace T {

    public class PgmMgr : Singleton<PgmMgr> {
        
        private IPgmPrime _iPgmPrime;
        private IPgm[] _iPgmArr;
        private IPgm _iCurr;
        
        public void Bind(IPgmPrime iPgmPrime) {
            _iPgmPrime = iPgmPrime;
        }

        public void Init() {
            _iCurr = null;
            Reg(_iPgmPrime.IPgmArr);
            Exe(_iPgmArr[0]);
        }

        public void InvokeUpd() {
            if (_iCurr != null) {
                _iCurr.InvokeUpd();
            }
        }

        public void Reg(IPgm[] iPgmArr) {
            _iPgmArr = iPgmArr;
        }

        public void Exe(byte ePgm) { // excute specific program by Enum 
            if (_iCurr != null) {
                _iCurr.End();
            }
            _iCurr = _iPgmArr[ePgm];
            _iCurr.Exe();
        }

        public void Exe(IPgm iPgm) { // excute specific program by interface
            if (_iCurr != null) {
                _iCurr.End();
            }
            _iCurr = iPgm;
            _iCurr.Exe();
        }

        public void Next() { // end current program and excute next program
            if (_iCurr != null && _iCurr.Next != null) {
                _iCurr.End();
                _iCurr = _iCurr.Next;
                _iCurr.Exe();
            }
        }
    }
}