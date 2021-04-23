using System;
using UnityEngine;
using UnityEngine.UI;
using T;

namespace DT {

    public class SplhUI : UI, IUI {

        public enum ESet : byte {
            A1, A2,
        }

        public enum EElem : byte {
            BtnA1, BtnB1, BtnB2, ImgA1, TxtA1, BtnA1_RTf
        }

        public SplhUI() {
            _keyArr = new string[Enum.GetNames(typeof(ESet)).Length];
            _keyArr[(byte)ESet.A1] = "SplhUIA1";
            _keyArr[(byte)ESet.A2] = "SplhUIA2";

            _setArr = new GameObject[_keyArr.Length];
            _setArr[(byte)ESet.A1] = null;
            _setArr[(byte)ESet.A2] = null;

            _elemArr = new object[Enum.GetNames(typeof(EElem)).Length][];
            _elemArr[(byte)EElem.BtnA1] = new object[] { null, ESet.A1, "BtnA1", typeof(Button) };
            _elemArr[(byte)EElem.BtnB1] = new object[] { null, ESet.A2, "BtnB1", typeof(Button) };
            _elemArr[(byte)EElem.BtnB2] = new object[] { null, ESet.A2, "BtnB2", typeof(Button) };
            _elemArr[(byte)EElem.ImgA1] = new object[] { null, ESet.A1, "ImgA1", typeof(Image) };
            _elemArr[(byte)EElem.TxtA1] = new object[] { null, ESet.A2, "TxtA1", typeof(Text) };
            _elemArr[(byte)EElem.BtnA1_RTf] = new object[] { null, ESet.A1, "BtnA1", typeof(RectTransform) };
        }

        public void InvkUpd() {

        }
    }
}