namespace T {

    public class PgmMgr : Sgltn<PgmMgr> {

        private IPgm[] _iPgmArr;
        private IPgm _iCurPgm;

        public void Bind(IPgmPrm iPgmPrm) {
            _iPgmArr = iPgmPrm.IPgmArr;
        }

        public void Init() {
            _iCurPgm = null;
        }

        public void InvkUpd() {
            if (_iCurPgm != null) {
                _iCurPgm.InvkUpd();
            }
        }

        public void Exe(byte ePgm) { // excute specific program by Enum
            if (_iCurPgm != null) {
                if (_iPgmArr[ePgm] == _iCurPgm) {
                    return;
                }
                _iCurPgm.End();
            }
            _iCurPgm = _iPgmArr[ePgm];
            _iCurPgm.Exe();
        }

        public void Next() { // end current program and excute next program
            if (_iCurPgm != null && _iCurPgm.Next != null) {
                _iCurPgm.End();
                _iCurPgm = _iCurPgm.Next;
                _iCurPgm.Exe();
            }
        }
    }
}