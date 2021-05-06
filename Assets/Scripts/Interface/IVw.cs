using UnityEngine;

namespace T {

    public interface IVw {

        void Stup(Camera cam); // setup
        void Stdn(); // setdown
        void Dfl(); // default
        void Prj(byte ePrj); // projection
        void Prj(SCamPrj sCamPrj); 
        void Ornt(byte eOrnt); // orient
        void Ornt(SOrnt3 sOrnt);
        void Mov(byte eMov); // movement
        void InvkUpd();
    }
}