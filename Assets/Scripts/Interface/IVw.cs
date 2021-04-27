using UnityEngine;

namespace T {

    public interface IVw {

        void Cam(Camera cam);
        void Dfl();
        void Prj(SCamPrj sCamPrj);
        void Ornt(SOrnt3 sOrnt);
        void Chg(byte chg);

        // extends
        void InvkUpd();
    }
}