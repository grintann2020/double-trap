using System.Collections.Generic;

namespace T {

    public class PgmMgr : Singleton<PgmMgr> {
        
        private IPgmPrime _iPgmPrime;
        private Dictionary<byte, IPgm> _pgmDic;
        private IPgm _currPgm;
        
        public void Bind(IPgmPrime iPgmPrime) {
            _iPgmPrime = iPgmPrime;
            _iPgmPrime.Mgr = this;
        }

        public void Init() {
            _pgmDic = new Dictionary<byte, IPgm>();
            _currPgm = null;
            _iPgmPrime.Init();
        }

        public void InvokeUpd() {
            if (_currPgm != null) {
                _currPgm.InvokeUpd();
            }
        }

        public void Reg(byte ePgm, IPgm iPgm) {
            _pgmDic.Add(ePgm, iPgm);
        }

        public void Link(IPgm iThis, IPgm iNext) {
            iThis.Next = iNext;
        }

        public void Exe(byte ePgm) { // excute specific program by Enum 
            if (_currPgm != null) {
                _currPgm.End();
            }
            _currPgm = _pgmDic[ePgm];
            _currPgm.Exe();
        }

        public void Exe(IPgm iPgm) { // excute specific program by interface
            if (_currPgm != null) {
                _currPgm.End();
            }
            _currPgm = iPgm;
            _currPgm.Exe();
        }

        public void Next() { // end current program and excute next program
            if (_currPgm != null && _currPgm.Next != null) {
                _currPgm.End();
                _currPgm = _currPgm.Next;
                _currPgm.Exe();
            }
        }
    }
}