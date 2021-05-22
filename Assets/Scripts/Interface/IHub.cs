using UnityEngine;

namespace T {

    public interface IHub {

        bool IsConn { get; }
        void Conn();
        void Dscn();
        void InvkUpd();
        void Act(byte eAct);
        void Mot(byte eMot);
        void StGO(byte eGO, GameObject go);
        GameObject GtGO(byte eGO);
        void StVal<T>(byte eVal, T val);
        T GtVal<T>(byte eVal);
    }
}