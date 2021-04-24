using UnityEngine;

namespace T {

    public interface IUI {

        bool IsInstl { get; }
        void SetCanv(Canvas canv);
        void Instl(); // install
        void Unstl(); // uninstall
        void Enbl(); // Enable();
        void EnblSet(byte eSet);
        void EnblElem(byte eElem);
        void Dsbl(); // Disable();
        void DsblSet(byte eSet);
        void DsblElem(byte eElem);
        // extends
        void InvkUpd();
    }
}