namespace T {

    public interface IPlc {
        
        ushort Rows { get; }
        ushort Cols { get; }
        void SetDef();
        void Constr();
        void Estb();
        void Elim();
    }
}