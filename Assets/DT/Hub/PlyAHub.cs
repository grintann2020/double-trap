using System;
using UnityEngine;
using T;

namespace DT {

    public class PlyAHub : Hub, IHub {

        public enum EGO {
            A1, A2, A3
        }

        public PlyAHub() {
            _goArr = new GameObject[Enum.GetNames(typeof(EGO)).Length];
            
        }
    }
}