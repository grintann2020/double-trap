namespace T {

    public interface ISpc {

        byte[][][] DflArr { get; }
        byte[][][] CurArr { get; }
        void Dfl();
        void Alt(byte eAlt);
        void Abstr(SCoord3 ctr);
        void Cnstr();
    }
}