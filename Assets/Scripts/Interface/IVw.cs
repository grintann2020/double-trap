using System.Collections.Generic;
using UnityEngine;

namespace T {

    public interface IVw {

        void SetCam(Camera cam);
        void SetCamPrj(SCamPrj sCamPrj);
        void Act(byte act);

        // extends
        void InvkUpd();
    }
}