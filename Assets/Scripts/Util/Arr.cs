namespace T {
    
    public static class Arr {

        public static T[] Add<T>(T[] arr, T itm) {
            if (arr == null) {
                return new T[] { itm };
            }
            T[] rslt = new T[arr.Length + 1];
            for (ushort i = 0; i < arr.Length; i++) {
                rslt[i] = arr[i];
            }
            rslt[arr.Length] = itm;
            return rslt;
        }

        public static T[] Rmv<T>(T[] arr, ushort idx) {
            if (arr == null) {
                return null;
            } else if (arr.Length == 0) {
                return arr;
            }
            T[] rslt = new T[arr.Length - 1];
            ushort r = 0;
            for (ushort i = 0; i < arr.Length; i++) {
                if (i != idx) {
                    rslt[r] = arr[i];
                    r++;
                }
            }
            return rslt;
        }

        public static T[] Dim<T>(object[][] arr, ushort idx) {
            T[] rslt = new T[arr.Length];
            for (ushort i = 0; i < arr.Length; i++) {
                rslt[i] = (T)arr[i][idx];
            }
            return rslt;
        }
    }
}