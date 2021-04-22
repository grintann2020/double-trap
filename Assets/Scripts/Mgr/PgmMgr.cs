namespace T {

    public class PgmMgr : Sgltn<PgmMgr> {

        private IPgm[] _iPgmArr;
        private IPgm _iCurrPgm;

        public void Bind(IPgmPrm iPgmPrm) {
            _iPgmArr = iPgmPrm.IPgmArr;
        }

        public void Init() {
            _iCurrPgm = null;
        }

        public void InvkUpd() {
            if (_iCurrPgm != null) {
                _iCurrPgm.InvkUpd();
            }
        }

        public void Exe(byte ePgm) { // excute specific program by Enum
            if (_iCurrPgm != null) {
                if (_iPgmArr[ePgm] == _iCurrPgm) {
                    return;
                }
                _iCurrPgm.End();
            }
            _iCurrPgm = _iPgmArr[ePgm];
            _iCurrPgm.Exe();
        }

        public void Next() { // end current program and excute next program
            if (_iCurrPgm != null && _iCurrPgm.Next != null) {
                _iCurrPgm.End();
                _iCurrPgm = _iCurrPgm.Next;
                _iCurrPgm.Exe();
            }
        }
    }
}