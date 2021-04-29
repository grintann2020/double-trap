namespace T {

    public struct SCoord2 {

        public float X { get { return _arr[0]; } }
        public float Y { get { return _arr[1]; } }
        public float[] Arr { get { return _arr; } }
        private float[] _arr;

        public SCoord2(float x, float y) {
            _arr = new float[] { x, y };
        }
    }

    public struct SCoord3 {

        public float X { get { return _arr[0]; } }
        public float Y { get { return _arr[1]; } }
        public float Z { get { return _arr[2]; } }
        public float[] Arr { get { return _arr; } }
        private float[] _arr;

        public SCoord3(float x, float y, float z) {
            _arr = new float[] { x, y, z };
        }
    }
}