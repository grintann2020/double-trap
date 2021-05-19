namespace T {

    public interface IHub {

        bool IsConn { get; }
        void Conn();
        void Dscn();
        void InvkUpd();
    }
}