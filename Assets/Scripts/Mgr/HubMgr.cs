namespace T {

    public class HubMgr : Sgltn<HubMgr> {

        private IHub[] _iHubArr;
        private IHub _iCurHub;

        public void Bind(IHubPrm iHubPrm) {
            _iHubArr = iHubPrm.IHubArr;
        }

        public void Init() {
            _iCurHub = null;
        }

        public void Conn(byte eHub) { // excute specific program by Enum
            if (_iCurHub != null) {
                if (_iHubArr[eHub] == _iCurHub) {
                    return;
                }
                _iCurHub.Dscn();
            }
            _iCurHub = _iHubArr[eHub];
            _iCurHub.Conn();
        }

        public void Dscn(byte eHub) {
            if (_iCurHub != null) {
                _iCurHub.Dscn();
                _iCurHub = null;
            }
        }

        public void InvkUpd() {
            if (_iCurHub != null) {
                _iCurHub.InvkUpd();
            }
        }

        public IHub Hub(byte eHub) {
            return _iHubArr[eHub];
        }
    }
}