namespace T {

    public class UIMgr : Singleton<UIMgr> {

        private IUI[] _iUIArr;

        public void Bind(IUIPrm iUIPrm) {
            _iUIArr = iUIPrm.IUIArr;
        }

        public void Init() {
            
        }
    }
}