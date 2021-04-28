namespace T {

    public interface ISpc {

        ushort DflRows { get; }
        ushort DflCols { get; }
        ushort DflLays { get; }
        ushort CurRows { get; }
        ushort CurCols { get; }
        ushort CurLays { get; }
        ushort[][][] DflArr { get; }
        ushort[][][] CurArr { get; }
        void Dfl();
        void Alt(byte eAlt);
    }
}