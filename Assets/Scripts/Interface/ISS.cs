namespace T {

    public interface ISS {

        IBlk[][][] Cnstr(byte[][][] eUArr, SCoord3 ctr);
        void Estb(IBlk[][][] iBlkArr, string[][] uArr);
        void Elim(IBlk[][][] iBlkArr);
    }
}