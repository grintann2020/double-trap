namespace T {

    public abstract class SS {

        protected byte _uWd; // unit width
        protected byte _uHt; // unit height

        public SS(byte uWd, byte uHt) {
            _uWd = uWd;
            _uHt = uHt;
        }

        public abstract IBlk[][][] Abstr(byte[][][] eUArr, SCoord3 ctr);
        public abstract void Cnstr(IBlk[][][] iBlkArr, string[][] uArr);
    }
}