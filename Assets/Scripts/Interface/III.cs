using System;

namespace T {

    public interface III { // interactive input

        void Instl();
        void Unstl();
        void Invk(byte eEvt, Action rct);
        void Waiv(byte eEvt, Action rct);
        void InvkUpd();
    }
}