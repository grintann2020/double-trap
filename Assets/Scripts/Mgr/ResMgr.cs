using System.Threading.Tasks;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine;

namespace T {

    public class ResMgr : Sgltn<ResMgr> {
        public delegate void DCb();
        public delegate void DCb<T>(T tObj);
        public delegate void DCbArr<T>(T[] tObjArr);

        public void Init() {

        }

        public void Load<TObj>(string key, DCb<TObj> dLoaded) {
            Addressables.LoadAssetAsync<TObj>(key).Completed += (AsyncOperationHandle<TObj> hdl) => {
                dLoaded(hdl.Result);
            };
        }

        public async void Load<TObj>(string[] keyArr, DCbArr<TObj> dLoaded) {
            TObj[] tObjArr = new TObj[keyArr.Length];
            Task[] taskArr = new Task[keyArr.Length];
            AsyncOperationHandle<TObj>[] hdlArr = new AsyncOperationHandle<TObj>[keyArr.Length];
            for (byte k = 0; k < keyArr.Length; k++) {
                hdlArr[k] = Addressables.LoadAssetAsync<TObj>(keyArr[k]);
                taskArr[k] = hdlArr[k].Task;
            }
            await Task.WhenAll(taskArr);
            for (byte k = 0; k < keyArr.Length; k++) {
                tObjArr[k] = hdlArr[k].Result;
            }
            dLoaded(tObjArr);
        }

        public void Inst(string key, Transform parent = null, DCb<GameObject> dInsted = null) { // Addressables.InstantiateAsync will clone asset directlty
            Addressables.InstantiateAsync(key, parent).Completed += (AsyncOperationHandle<GameObject> hdl) => {
                dInsted(hdl.Result);
            };
        }

        public void Inst(string key, Vector3 pos, Quaternion rot, Transform parent = null, DCb<GameObject> dInsted = null) { // Addressables.InstantiateAsync will clone asset directlty
            Addressables.InstantiateAsync(key, pos, rot, parent).Completed += (AsyncOperationHandle<GameObject> hdl) => {
                dInsted(hdl.Result);
            };
        }

        public async void Inst(string[] keyArr,  Transform parent = null, DCbArr<GameObject> dInsted = null) { // Addressables.InstantiateAsync will clone asset directlty
            GameObject[] goArr = new GameObject[keyArr.Length];
            Task[] taskArr = new Task[keyArr.Length];
            AsyncOperationHandle<GameObject>[] hdlArr = new AsyncOperationHandle<GameObject>[keyArr.Length];
            for (byte k = 0; k < keyArr.Length; k++) {
                hdlArr[k] = Addressables.InstantiateAsync(keyArr[k], parent);
                taskArr[k] = hdlArr[k].Task;
            }
            await Task.WhenAll(taskArr);
            for (byte k = 0; k < keyArr.Length; k++) {
                goArr[k] = hdlArr[k].Result;
            }
            if (dInsted != null) {
                dInsted(goArr);
            }
        }

        public async void Inst(string[] keyArr, Vector3[] posArr, Quaternion[] rotArr, Transform parent = null, DCbArr<GameObject> dInsted = null) {
            if (keyArr.Length != posArr.Length || keyArr.Length != rotArr.Length) {
                Debug.LogError("array as param in Inst Method -- was vaild !");
                return;
            }
            GameObject[] goArr = new GameObject[keyArr.Length];
            Task[] taskArr = new Task[keyArr.Length];
            AsyncOperationHandle<GameObject>[] hdlArr = new AsyncOperationHandle<GameObject>[keyArr.Length];
            for (byte k = 0; k < keyArr.Length; k++) {
                hdlArr[k] = Addressables.InstantiateAsync(keyArr[k], posArr[k], rotArr[k], parent);
                taskArr[k] = hdlArr[k].Task;
            }
            await Task.WhenAll(taskArr);
            for (byte k = 0; k < keyArr.Length; k++) {
                goArr[k] = hdlArr[k].Result;
            }
            if (dInsted != null) {
                dInsted(goArr);
            }
        }

        public void Rls<TObj>(TObj tObj, DCb dRlsed = null) {
            Addressables.Release<TObj>(tObj);
            if (dRlsed != null) {
                dRlsed();
            }
        }

        public void Rls<TObj>(TObj[] tObjArr, DCb dRlsed = null) {
            for (ushort o = 0; o < tObjArr.Length; o++) {
                Addressables.Release<TObj>(tObjArr[o]);
            }
            if (dRlsed != null) {
                dRlsed();
            }
        }
    }
}