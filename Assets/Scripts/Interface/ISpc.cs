namespace T {

    public interface ISpc {

        byte[][][] DflArr { get; }
        byte[][][] CurArr { get; }
        void Dfl(); // default
        void Alt(byte eAlt); // alter
        void Cnstr(SCoord3 ctr); // construct
        void Estb(); // establish
        void Elim(); // eliminate
    }
}