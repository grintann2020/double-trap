namespace T {

    public class Singleton<T> where T : new() {
        
        protected static T _ins;
        public static T Ins {
            get {
                if (_ins == null) {
                    _ins = new T();
                }
                return _ins; // Returns the instance of this singleton.
            }
        }
    }
}