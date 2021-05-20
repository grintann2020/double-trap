using UnityEngine;

namespace T {

    public interface IHub {

        bool IsConn { get; }
        void Conn();
        void Dscn();
        void InvkUpd();
        void St(byte eGO, GameObject go);
        GameObject Gt(byte eGO);
    }
}