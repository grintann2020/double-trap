using UnityEngine;

namespace T {
    
    [CreateAssetMenu(fileName = "Settings", menuName = "ScriptableObject/Settings", order = 0)]
    public class Settings : ScriptableObject {

        public EGame EGame;
        public ScrRez ScrRez;

        public IPrime IPrime {
            get {
                switch (EGame) {
                    case EGame.DT:
                        return new DTPrime();
                    default:
                        return new DTPrime();
                }
            }
        }
    }
}