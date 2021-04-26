using System;
using UnityEngine;
using UnityEngine.UI;
using T;

namespace DT {

    public class FstUI : UI, IUI {

        public enum ESet : byte {
            B1,
        }

        public enum EElem : byte {
            ImgB1
        }

        public FstUI() {
            _keyArr = new string[Enum.GetNames(typeof(ESet)).Length];
            _keyArr[(byte)ESet.B1] = "FstUI";

            _setArr = new GameObject[Enum.GetNames(typeof(ESet)).Length];
            _setArr[(byte)ESet.B1] = null;

            _elemArr = new object[Enum.GetNames(typeof(EElem)).Length][];
            _elemArr[(byte)EElem.ImgB1] = new object[] { null, ESet.B1, "ImgB1", typeof(Image) };

            _bssArr = new _bss[0];
        }

        public void InvkUpd() {
            // Debug.Log("FstUI -- InvkUpd");
        }
    }
}