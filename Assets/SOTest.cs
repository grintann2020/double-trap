using UnityEngine;
using UnityEngine.UI;

namespace T {

    [CreateAssetMenu(fileName = "TestSO", menuName = "ScriptableObject/TestSO", order = 0)]
    public class SOTest : ScriptableObject {
        public Button btn;
    }
}