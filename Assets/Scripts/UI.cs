using UnityEngine;

namespace T {

    public class UI {

        protected ushort[] _eResArr;
        protected object[][] _objArr;
        protected object[] _elemArr;

        public void Instl() {
            ResMgr.Ins.Load<GameObject>(_eResArr, () => {
                Debug.Log("1 _eResArr[0] --> " + ResMgr.Ins.Get<GameObject>(_eResArr[0]));
                Debug.Log("1 _eResArr[1] --> " + ResMgr.Ins.Get<GameObject>(_eResArr[1]));

                ResMgr.Ins.Load<GameObject>(_eResArr, () => {
                    Debug.Log("2 _eResArr[0] --> " + ResMgr.Ins.Get<GameObject>(_eResArr[0]));
                    Debug.Log("2 _eResArr[1] --> " + ResMgr.Ins.Get<GameObject>(_eResArr[1]));
                });
            });

            
            // string[] keyArr = Arr.Dim<string>(_objArr, 0);
            // ResMgr.Ins.Load<GameObject>(keyArr, (GameObject[] goArr) => {
            //     for (byte g = 0; g < _objArr.Length; g++) {
            //         _objArr[g][1] = goArr[g];
            // Debug.Log("goArr[g] --> " + _objArr[g][1]);
            // }
            // });
        }

        public void Unstl() {
            // GameObject[] goArr = Arr.Dim<GameObject>(_objArr, 1);
            // ResMgr.Ins.Rls<GameObject>(goArr, () => {
            //     for (byte o = 0; o < _objArr.Length; o++) {
            //         _objArr[o][1] = null;
            //     }
            // });
        }

        public void Rst() {

        }
    }
}