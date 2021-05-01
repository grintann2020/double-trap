using UnityEngine;

namespace T {

    public interface IBlk {

        SGrid3 Grid { get; }
        SCoord3 Coord { get; }
        ushort Row { get; }
        ushort Col { get; }
        ushort Lay { get; }
        float X { get; }
        float Z { get; }
        float Y { get; }
        byte EU { get; set; }
        void Inp(GameObject go);
    }
}