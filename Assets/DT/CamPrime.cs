using System;
using T;

namespace DT {

    public enum ELens : byte {
        UI, Play
    }

    public class CamPrime : ICamPrime {

        public ILens[] ILensArr { get { return _iLensArr; } }
        private ILens[] _iLensArr = new ILens[Enum.GetNames(typeof(ELens)).Length];
        // camera objects
        private UILens _uiLens = new UILens(); // Menu Camera
        private PlayLens _playLens = new PlayLens(); // Stage Camera

        public CamPrime() {
            _iLensArr[(byte)ELens.UI] = _uiLens;
            _iLensArr[(byte)ELens.Play] = _playLens;
        }
    }
}