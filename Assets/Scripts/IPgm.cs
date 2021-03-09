namespace T {

    public interface IPgm {

        IPgm Next { get; set; }
        void Bind(PgmMgr pgmMgr);
        void InvokeUpd();
        void Exe();
        void End();
    }
}
