using System.Collections.Generic;

namespace T {

    public class PgmMgr : Singleton<PgmMgr> {
        
        private IPgmPrime _iPgmPrime;
        // private Dictionary<byte, IPgm> _pgmDic;
        private IPgm[] _iArr;
        private IPgm _iCurr;
        
        public void Bind(IPgmPrime iPgmPrime) {
            _iPgmPrime = iPgmPrime;
            // _iPgmPrime.Mgr = this;
        }

        public void Init() {
            // _pgmDic = new Dictionary<byte, IPgm>();
            _iCurr = null;
            _iPgmPrime.Init();
            // _iArr = _iPgmPrime.IPgmArr;
            Reg(_iPgmPrime.IArr);
            Exe(_iArr[0]);
        }

        public void InvokeUpd() {
            if (_iCurr != null) {
                _iCurr.InvokeUpd();
            }
        }

        // public void Reg(byte ePgm, IPgm iPgm) {
        //     _pgmDic.Add(ePgm, iPgm);
        // }

        public void Reg(IPgm[] iArr) {
            _iArr = iArr;
        }

        // public void Link(IPgm iThis, IPgm iNext) {
        //     iThis.Next = iNext;
        // }

        public void Exe(byte ePgm) { // excute specific program by Enum 
            if (_iCurr != null) {
                _iCurr.End();
            }
            _iCurr = _iArr[ePgm];
            _iCurr.Exe();
        }

        // public void Exe(byte ePgm) { // excute specific program by Enum 
        //     if (_iCurr != null) {
        //         _iCurr.End();
        //     }
        //     _iCurr = _pgmDic[ePgm];
        //     _iCurr.Exe();
        // }

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