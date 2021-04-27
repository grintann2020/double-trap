namespace T {

    public static class SquCalc {

        public static SCoord3 GetCtr(int xUs, int zUs, float wd) { // xUs = number of units along x axis

            return new SCoord3(
                -((float)xUs * wd / 2) + (wd / 2),
                0.0f,
                ((float)zUs * wd / 2) - (wd / 2)
            );
        }
    }
}