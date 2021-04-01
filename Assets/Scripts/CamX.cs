using UnityEngine;
using System.Collections.Generic;

namespace T {

    public class CamX {

        public SOrientC3 DefOrient {
            get { return _defOrient; }
            protected set { _defOrient = value; }
        }
        private SOrientC3 _defOrient;
        // private List<SOrientC3> _orientLis;

        public CamX() {
            Debug.Log("Lens Lens Lens");
            // _orientLis = new List<SOrientC3>();
        }
    }
}