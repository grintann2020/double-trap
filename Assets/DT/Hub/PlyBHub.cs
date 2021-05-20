using System;
using UnityEngine;
using T;

namespace DT {

    public class PlyBHub : Hub, IHub {

        public enum EGO {
            B1, B2, B3
        }

        public PlyBHub() {
            _goArr = new GameObject[Enum.GetNames(typeof(EGO)).Length];
            
        }
    }
}