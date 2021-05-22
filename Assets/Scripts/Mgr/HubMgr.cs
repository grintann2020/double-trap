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

        public void Act(byte eAct) {
            _iCurHub.Act(eAct);
        }

        public void Act(byte eHub, byte eAct) {
            _iHubArr[eHub].Act(eAct);
        }

        public void Mot(byte eAct) {
            _iCurHub.Mot(eAct);
        }

        public void Mot(byte eHub, byte eAct) {
            _iHubArr[eHub].Mot(eAct);
        }

        public void StGO(byte eGO, GameObject go) {
            _iCurHub.StGO(eGO, go);
        }

        public void StGO(byte eHub, byte eGO, GameObject go) {
            _iHubArr[eHub].StGO(eGO, go);
        }

        public GameObject GtGO(byte eGO) {
            return _iCurHub.GtGO(eGO);
        }

        public GameObject GtGO(byte eHub, byte eGO) {
            return _iHubArr[eHub].GtGO(eGO);
        }

        public void StVal<T>(byte eVal, T val) {
            _iCurHub.StVal<T>(eVal, val);
        }

        public void StVal<T>(byte eHub, byte eVal, T val) {
            _iHubArr[eHub].StVal<T>(eVal, val);
        }

        public T GtVal<T>(byte eVal) {
            return _iCurHub.GtVal<T>(eVal);
        }

        public T GtVal<T>(byte eHub, byte eVal) {
            return _iHubArr[eHub].GtVal<T>(eVal);
        }
    }
}