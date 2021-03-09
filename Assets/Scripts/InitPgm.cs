namespace T {

    public class InitPgm : IPgm {

        public IPgm Next { get; set; }
        private PgmMgr _mgr;

        public void Bind(PgmMgr mgr) {
            _mgr = mgr;
        }

        public void InvokeUpd() {

        }

        public void Exe() {

        }

        public void End() {

        }
    }
}