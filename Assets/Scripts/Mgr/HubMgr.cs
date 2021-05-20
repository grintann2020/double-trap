using UnityEngine;

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

        public IHub Hub() {
            return _iCurHub;
        }

        public IHub Hub(byte eHub) {
            return _iHubArr[eHub];
        }

        public void St(byte eGO, GameObject go) {
            _iCurHub.St(eGO, go);
        }

        public void St(byte eHub, byte eGO, GameObject go) {
            _iHubArr[eHub].St(eGO, go);
        }

        public GameObject Gt(byte eGO) {
            return _iCurHub.Gt(eGO);
        }

        public GameObject Gt(byte eHub, byte eGO) {
            return _iHubArr[eHub].Gt(eGO);
        }
    }
}