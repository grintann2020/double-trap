using UnityEngine;

namespace T {

    public interface IUI {

        bool IsInstl { get; }
        void Canv(Canvas canv);
        void Instl(); // install
        void Unstl(); // uninstall
        void Enbl(); // Enable();
        void Enbl(byte eSet);
        void EnblElem(byte eElem);
        void Dsbl(); // Disable();
        void Dsbl(byte eSet);
        void DsblElem(byte eElem);
        void Front();
        void Back();
        void Front(byte eSet);
        void Back(byte eSet);
        // extends
        void InvkUpd();
    }
}