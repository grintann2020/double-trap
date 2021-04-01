using System;
using T;

namespace DT {

    public enum ECamProj : byte {
        UI, Play
    }

    public class ViewPrime : IViewPrime {

        public SCamProj[] SCamProjArr { get { return _sCamProjArr; } }
        private SCamProj[] _sCamProjArr = new SCamProj[Enum.GetNames(typeof(ECamProj)).Length];
        // lens objects
        // private UILens _uiLens = new UILens(); // Menu Camera
        // private PlayLens _playLens = new PlayLens(); // Stage Camera

        public ViewPrime() {
            // _iLensArr[(byte)ELens.UI] = _uiLens;
            // _iLensArr[(byte)ELens.Play] = _playLens;
        }
    }
}