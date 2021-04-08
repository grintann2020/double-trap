namespace T {

    public interface IPgm {

        IPgm Next { get; set; }
        void InvkUpd();
        void Exe();
        void End();
    }
}
