namespace T {

    public class LangMgr : Singleton<LangMgr> {

        private ILangPrime _iLangPrime;

        public void Bind(ILangPrime iLangPrime) {
            _iLangPrime = iLangPrime;
        }

        public void Init() {

        }
    }
}