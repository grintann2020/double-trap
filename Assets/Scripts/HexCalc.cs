namespace T {

    public static class HexCalc {

        private const float ASPECT_RATIO = 1.732050807568877f;

        private static int[,][] dirArr = {
            {new int[]{0, +1}, new int[]{-1,  0}, new int[]{-1, -1}, new int[]{0, -1}, new int[]{+1, -1}, new int[]{+1,  0}},
            {new int[]{0, +1}, new int[]{-1, +1}, new int[]{-1,  0}, new int[]{0, -1}, new int[]{+1,  0}, new int[]{+1, +1}}
        };

        public static int[] Adjacency(int row, int dir) {
            int parity = row & 1;
            return dirArr[parity, dir];
        }

        // public Hex Adjacency(Hex[,] hexs, Hex hex, int hexDirection)
        // {

        // if (hex.Row <= 0 || hex.Col <= 0 || hex.Row >= hexs.GetLength(0) - 1 || hex.Col >= hexs.GetLength(1) - 1)
        // {
        //     return null;
        // }
        //     int parity = hex.Row & 1;
        //     int[] direct = this.dirArr[parity, hexDirection];
        //     Debug.Log(
        //         " direct = "+ hexDirection + ", " +
        //         " row = " + hex.Row + ", row + direct[0] = " + (hex.Row + direct[0]) + " || " +
        //         " col = " + hex.Col + ", col + direct[1] = " + (hex.Col + direct[1])
        //     );
        //     return hexs[hex.Row + direct[0], hex.Col + direct[1]];
        // }

        public static (float hDist, float vDist) DistributeDist(float size) {
            return (HDist(size), VDist(size));
        }

        public static float HDist(float size) {
            return UnitW(HexW(size)) * 2;
        }

        public static float VDist(float size) {
            return UnitH(HexH(size)) * 3;
        }

        public static float UnitW(float hexW) {
            return hexW / 2;
        }

        public static float UnitH(float hexH) {
            return hexH / 4;
        }

        public static float HexW(float size) {
            return size * ASPECT_RATIO;
        }

        public static float HexH(float size) {
            return size * 2;
        }

        public static SCoord3 CenterPos(int hUnits, int vUnits, float hUnitSpacing, float vUnitSpacing) {
            return new SCoord3(
                -((hUnitSpacing * (float)hUnits) / 2) + (hUnitSpacing / 2),
                0.0f,
                ((vUnitSpacing * (float)vUnits) / 2) - (vUnitSpacing / 2)
            );
        }
    }
}