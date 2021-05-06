namespace T {

    public abstract class SS {

        protected byte _uWd; // unit width
        protected byte _uHt; // unit height

        public SS(byte uWd, byte uHt) {
            _uWd = uWd;
            _uHt = uHt;
        }

        public abstract IBlk[][][] Cnstr(byte[][][] eUArr, SCoord3 ctr);
        public abstract void Estb(IBlk[][][] iBlkArr, string[][] uArr);
        public abstract void Elim(IBlk[][][] iBlkArr);
    }
}