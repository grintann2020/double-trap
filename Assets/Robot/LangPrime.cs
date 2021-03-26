using System;
using UnityEngine;
using T;

namespace Robot {

    public enum ETerm : ushort {
        GrinBit,
        DoubleTrap,
        Test,
        One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten
    }

    public class LangPrime : ILangPrime {

        public string[][] TermArr { get { return _termArr; } }
        private string[][] _termArr;

        public LangPrime() {
            float dur = UnityEngine.Time.realtimeSinceStartup;

            _termArr = new string[Enum.GetNames(typeof(ETerm)).Length][];
            _termArr[(byte)ETerm.GrinBit] = new string[] { "Grin Bit", "Grin Bit" };
            _termArr[(byte)ETerm.DoubleTrap] = new string[] { "DoubleTrap", "雙重陷阱", "雙重陷阱" };
            _termArr[(byte)ETerm.Test] = new string[] { "Test", "測試", "測測" };
            _termArr[(byte)ETerm.One] = new string[] { "One", "壹", "一" };
            _termArr[(byte)ETerm.Two] = new string[] { "Two", "貳", "二" };
            _termArr[(byte)ETerm.Three] = new string[] { "Three", "參", "三" };
            _termArr[(byte)ETerm.Four] = new string[] { "Four", "肆", "四" };
            _termArr[(byte)ETerm.Five] = new string[] { "Five", "伍", "五" };
            _termArr[(byte)ETerm.Six] = new string[] { "Six", "陸", "六" };
            _termArr[(byte)ETerm.Seven] = new string[] { "Seven", "柒", "七" };
            _termArr[(byte)ETerm.Eight] = new string[] { "Eight", "捌", "八" };
            _termArr[(byte)ETerm.Nine] = new string[] { "Nine", "玖", "九" };
            _termArr[(byte)ETerm.Ten] = new string[] { "Ten", "拾", "十" };

            Debug.Log("dur --> " + (UnityEngine.Time.realtimeSinceStartup - dur));
        }
    }
}