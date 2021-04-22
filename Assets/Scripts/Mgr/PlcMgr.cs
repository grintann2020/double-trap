namespace T {

    public class PlcMgr : Sgltn<PlcMgr> {

        private IPlc[] _iPlcArr;
        private IPlc _iCurrPlc;

        public void Bind(IPlcPrm iPlcPrm) {
            _iPlcArr = iPlcPrm.IPlcArr;
        }

        public void Init() {
            _iCurrPlc = null;
        }

        public void SetDf(byte ePlc) { 
            if (_iCurrPlc != null) {
                _iPlcArr[ePlc].SetDef();
            }
        }

        public void Constr(byte ePlc) { // excute specific program by Enum
            if (_iCurrPlc != null) {
                if (_iPlcArr[ePlc] == _iCurrPlc) {
                    return;
                }
                _iCurrPlc.Elim();
            }
            _iCurrPlc = _iPlcArr[ePlc];
            _iCurrPlc.Constr();
        }
    }
}