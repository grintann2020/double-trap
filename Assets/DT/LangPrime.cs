using System;
using UnityEngine;
using T;

namespace DT {

    public enum ETerm : ushort {
        GrinBit,
        DoubleTrap,
        Test,
        One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S
    }

    public class LangPrime : ILangPrime {

        public string[][] TermArr { get { return _termArr; } }
        private string[][] _termArr = new string[Enum.GetNames(typeof(ETerm)).Length][];

        public LangPrime() {
            float dur = UnityEngine.Time.realtimeSinceStartup;
            
            
            _termArr[(ushort)ETerm.One] = new string[] { "One", "壹", "一" };
            _termArr[(ushort)ETerm.Two] = new string[] { "Two", "貳", "二" };
            _termArr[(ushort)ETerm.Three] = new string[] { "Three", "參", "三" };
            _termArr[(ushort)ETerm.Four] = new string[] { "Four", "肆", "四" };
            _termArr[(ushort)ETerm.Five] = new string[] { "Five", "伍", "五" };
            _termArr[(ushort)ETerm.Six] = new string[] { "Six", "陸", "六" };
            _termArr[(ushort)ETerm.Seven] = new string[] { "Seven", "柒", "七" };
            _termArr[(ushort)ETerm.Eight] = new string[] { "Eight", "捌", "八" };
            _termArr[(ushort)ETerm.Nine] = new string[] { "Nine", "玖", "九" };
            _termArr[(ushort)ETerm.Ten] = new string[] { "Ten", "拾", "十" };

            // _termArr = new string[Enum.GetNames(typeof(ETerm)).Length][];
            // _termArr[(ushort)ETerm.GrinBit] = new string[] { "Grin Bit", "Grin Bit" };
            // _termArr[(ushort)ETerm.DoubleTrap] = new string[] { "DoubleTrap", "雙重陷阱", "雙重陷阱" };
            // _termArr[(ushort)ETerm.Test] = new string[] { "Test", "測試", "測測" };

            // _termArr[10] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[11] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[12] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[13] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[14] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[15] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[16] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[17] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[18] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[19] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };
            // _termArr[20] = new string[] { 
            //     "TenTenTenTenTenTenTenTenTenTenTen",
            //     "拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾拾",
            //     "十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十十"
            // };

            // Debug.Log("realtimeSinceStartup --> "+ UnityEngine.Time.realtimeSinceStartup);
            Debug.Log("dur --> "+ (UnityEngine.Time.realtimeSinceStartup - dur));
        }
    }
}