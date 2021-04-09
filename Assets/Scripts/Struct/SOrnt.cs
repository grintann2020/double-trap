using System;

namespace T {

    public struct SOrntC2 {

        public SCoord2 A;
        public SCoord2 B;
        public float DistX { get { return B.X - A.X; } }
        public float DistY { get { return B.Y - A.Y; } }
        public float Dist {
            get { return (float)Math.Sqrt(Math.Pow(DistX, 2) + Math.Pow(DistY, 2)); }
        }

        public SOrntC2(SCoord2 a, SCoord2 b) {
            A = a;
            B = b;
        }
    }

    public struct SOrntC3 {

        public SCoord3 A;
        public SCoord3 B;
        public float DistX { get { return B.X - A.X; } }
        public float DistY { get { return B.Y - A.Y; } }
        public float DistZ { get { return B.Z - A.Z; } }
        public float Dist {
            get { return (float)Math.Sqrt(Math.Pow(DistX, 2) + Math.Pow(DistY, 2) + Math.Pow(DistZ, 2)); }
        }

        public SOrntC3(SCoord3 a, SCoord3 b) {
            A = a;
            B = b;
        }
    }

    public struct SOrntG2 {

        public SGrid2 A;
        public SGrid2 B;
        public float DistX { get { return B.Row - A.Row; } }
        public float DistY { get { return B.Col - A.Col; } }
        public float Dist {
            get { return (float)Math.Sqrt(Math.Pow(DistX, 2) + Math.Pow(DistY, 2)); }
        }

        public SOrntG2(SGrid2 a, SGrid2 b) {
            A = a;
            B = b;
        }
    }

    public struct SOrntG3 {

        public SGrid3 A;
        public SGrid3 B;
        public float DistX { get { return B.Row - A.Row; } }
        public float DistY { get { return B.Lay - A.Lay; } }
        public float DistZ { get { return B.Col - A.Col; } }
        public float Dist {
            get { return (float)Math.Sqrt(Math.Pow(DistX, 2) + Math.Pow(DistZ, 2) + Math.Pow(DistY, 2)); }
        }

        public SOrntG3(SGrid3 a, SGrid3 b) {
            A = a;
            B = b;
        }
    }
}