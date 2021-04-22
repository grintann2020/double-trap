using System;
using System.Collections;
using UnityEngine;
using T;

namespace DT {

    public class SplhUI : UI, IUI {

        // private enum EGO {
        //     A1, A2
        // }

        // public GameObject SplhUIA1;

        public SplhUI() {
            // _objArr = new object[2][];
            // _objArr[(byte)EGO.A1] = new object[] { "SplhUIA1", null };
            // _objArr[(byte)EGO.A2] = new object[] { "SplhUIA2", null };
            _eResArr = new ushort[2];
            _eResArr[0] = (ushort)ERes.SplhUIA1;
            _eResArr[1] = (ushort)ERes.SplhUIA2;
        }

        public void InvkUpd() {

        }
    }
}