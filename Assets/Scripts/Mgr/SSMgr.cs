namespace T {

    public class SSMgr : Sgltn<SSMgr> {

        private ISS[] _iSSArr;

        public void Bind(ISSPrm iSSPrm) {
            _iSSArr = iSSPrm.ISSArr;
        }

        public void Init() {

        }

        public void Dfl(byte eSS) {   
            _iSSArr[eSS].Dfl();
        }

        public ushort[][][] CurSS(byte eSS) {
            return _iSSArr[eSS].CurArr;
        }

        public ushort[][][] DflSS(byte eSS) {
            return _iSSArr[eSS].DflArr;
        }



        // public void Constr(byte eSS) { // excute specific program by Enum
        //     if (_iCurrSS != null) {
        //         if (_iSSArr[eSS] == _iCurrSS) {
        //             return;
        //         }
        //         _iCurrSS.Elim();
        //     }
        //     _iCurrSS = _iSSArr[eSS];
        //     _iCurrSS.Constr();
        // }
    }
}