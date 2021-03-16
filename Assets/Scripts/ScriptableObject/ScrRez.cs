using System;
using UnityEngine;

namespace T {

    [CreateAssetMenu(fileName = "ScrRez", menuName = "ScriptableObject/ScrRez", order = 0)]
    public class ScrRez : ScriptableObject {

        public float Max = 0.0f;
        public float Min = 0.0f;
        public byte NumOfLv = 0;
        public byte Lv = 0;

        public bool IsPort { // is portrait or landscape
            get { return Screen.height > Screen.width; }
        }

        public float AR { // aspect ratio
            get { return (float)Screen.height / (float)Screen.width; } // e.g. 9:16 = 0.5625
        }

        public int Wd { // width
            get { return (int)Math.Round((Screen.width * Max - Screen.width * Min) / NumOfLv * Lv + Screen.width * Min); }
        }

        public int Ht { // height
            get { return (int)Math.Round((float)Wd * AR); }
        }
    }
}