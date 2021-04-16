using UnityEngine;

namespace T {

    public class SingletonMB<T> : MonoBehaviour where T : MonoBehaviour { // Singleton base class.
                                                                          // Derive this class to make it Singleton
            protected static T _ins;
            public static T Ins {
            get {
                if (_ins == null) {
                    _ins = (T)FindObjectOfType(typeof(T));
                    if (_ins == null) {
                        GameObject obj = new GameObject(typeof(T).ToString());
                        _ins = obj.AddComponent<T>();
                    }
                    DontDestroyOnLoad(_ins); // Keep the object alive.
                }
                return _ins; // Returns the instance of this singleton.
            }
        }
    }
}