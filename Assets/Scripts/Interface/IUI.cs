using UnityEngine;

namespace T {

    public interface IUI {

        void SetCanv(Canvas canv);
        void Instl(); // install
        void Unstl(); // uninstall
        void Enbl(); // Enable();
        void EnblSet(byte eSet);
        void EnblElem(byte eElem);
        void Dsbl(); // Disable();
        void DsblSet(byte eSet);
        void DsblElem(byte eElem);
        // void Rst(); // reset
        // void InvkUpd();
    }
}