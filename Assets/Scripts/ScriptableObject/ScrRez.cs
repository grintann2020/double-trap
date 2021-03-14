using System;
using UnityEngine;

namespace T {

    [CreateAssetMenu(fileName = "ScrRez", menuName = "ScriptableObject/ScrRez", order = 0)]
    public class ScrRez : ScriptableObject {

        // public DispAR[] DispARArr;
        public float Max;
        public float Min;
        public int NumOfLv;

        public bool IsPort { // is portrait or landscape
            get { return Screen.height > Screen.width; }
        }

        public float AR { // aspect ratio
            get { return (float)Screen.height / (float)Screen.width; } // e.g. 9:16 = 0.5625
        }

        public int Wd { // width
            get {
                if (IsPort) {

                } else {

                }
                // return IsPort ? Short。 : Long;
                return 0;
            }
        }

        public int Ht { // height
            get { return (int)Math.Round(Wd * AR); }
        }

        // private int[] _longArr;
        // private int[] _shortArr;
        // private DispAR _dispAR;

        // private int[] GenrLenArr(int num, int len) { // calculate and return the array of length
        //     int[] lenArr = new int[num];
        //     int unit = (int)Math.Round((float)len / (float)num);
        //     for (int i = 0; i < num; i++) {
        //         lenArr[i] = unit * (i + 1);
        //     }
        //     return lenArr;
        // }

        // public void DecideAR() {
        //     DispAR dispAR = DispARArr[0];
        //     float diff_A = Math.Abs(Ratio - dispAR.ToFloat(IsPort));
        //     for (byte i = 1; i < DispARArr.Length; i++) {
        //         float diff_B = Math.Abs(Ratio - DispARArr[i].ToFloat(IsPort));
        //         if (diff_B < diff_A) {
        //             diff_A = diff_B;
        //             dispAR = DispARArr[i];
        //         }
        //     }
        //     _dispAR = dispAR;
        //     Debug.Log(_dispAR.Long + ":" + _dispAR.Short);

        //     _longArr = GenrLenArr(NumOfLv, IsPort ? Screen.height : Screen.width);
        //     _shortArr = GenrLenArr(NumOfLv, IsPort ? Screen.width : Screen.height);

        //     for (int i = 0; i < NumOfLv; i++) {
        //         Debug.Log(_longArr[i] + ":" + _shortArr[i] + " / " + (float)Screen.width + ":" + Screen.height);
        //     }
        }
    }
}