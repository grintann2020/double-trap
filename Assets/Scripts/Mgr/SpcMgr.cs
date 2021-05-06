namespace T {

    public class SpcMgr : Sgltn<SpcMgr> {

        private ISpc[] _iSpcArr;

        public void Bind(ISpcPrm iSpcPrm) {
            _iSpcArr = iSpcPrm.ISpcArr;
        }

        public void Init() {

        }

        public void Dfl(byte eSpc) {   
            _iSpcArr[eSpc].Dfl();
        }

        public ISpc Spc(byte eSpc) {
            return _iSpcArr[eSpc];
        }

        public byte[][][] DflArr(byte eSpc) {
            return _iSpcArr[eSpc].DflArr;
        }

        public byte[][][] CurArr(byte eSpc) {
            return _iSpcArr[eSpc].CurArr;
        }

        public void Alt(byte eSpc, byte eAlt) {
            _iSpcArr[eSpc].Alt(eAlt);
        }

        public void Cnstr(byte eSpc, SCoord3 ctr) {
            _iSpcArr[eSpc].Cnstr(ctr);
        }

        public void Estb(byte eSpc) {
            _iSpcArr[eSpc].Estb();
        }

        public void Blk(byte eSpc, SGrid3 grid) {
            // _iSpcArr[eSpc].Blk();
        }
    }
}