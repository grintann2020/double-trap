using System.Threading.Tasks;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine;

namespace T {

    public class ResMgr : Sgltn<ResMgr> {
        public delegate void CB();
        public delegate void CB<T>(T obj);
        public delegate void CBArr<T>(T[] objArr);
        // private object[][] _resArr;

        public void Init() {

        }

        public void Load<TObj>(string key, CB<TObj> loaded) {
            Addressables.LoadAssetAsync<TObj>(key).Completed += (AsyncOperationHandle<TObj> hdl) => {
                loaded(hdl.Result);
            };
        }

        public async void Load<TObj>(string[] keyArr, CBArr<TObj> loaded) {
            TObj[] objArr = new TObj[keyArr.Length];
            Task[] taskArr = new Task[keyArr.Length];
            AsyncOperationHandle<TObj>[] hdlArr = new AsyncOperationHandle<TObj>[keyArr.Length];
            for (byte k = 0; k < keyArr.Length; k++) {
                hdlArr[k] = Addressables.LoadAssetAsync<TObj>(keyArr[k]);
                taskArr[k] = hdlArr[k].Task;
            }
            await Task.WhenAll(taskArr);
            for (byte k = 0; k < keyArr.Length; k++) {
                objArr[k] = hdlArr[k].Result;
            }
            loaded(objArr);
        }

        public void Inst(string key, CB<GameObject> insted, Transform parent = null) { // Addressables.InstantiateAsync will clone asset directlty
            Addressables.InstantiateAsync(key, parent).Completed += (AsyncOperationHandle<GameObject> hdl) => {
                insted(hdl.Result);
            };
        }

        public void Inst(string key, CB<GameObject> insted, Vector3 pos, Quaternion rot, Transform parent = null) { // Addressables.InstantiateAsync will clone asset directlty
            Addressables.InstantiateAsync(key, pos, rot, parent).Completed += (AsyncOperationHandle<GameObject> hdl) => {
                insted(hdl.Result);
            };
        }

        public async void Inst(string[] keyArr, CBArr<GameObject> insted, Transform parent = null) { // Addressables.InstantiateAsync will clone asset directlty
            GameObject[] objArr = new GameObject[keyArr.Length];
            Task[] taskArr = new Task[keyArr.Length];
            AsyncOperationHandle<GameObject>[] hdlArr = new AsyncOperationHandle<GameObject>[keyArr.Length];
            for (byte k = 0; k < keyArr.Length; k++) {
                hdlArr[k] = Addressables.InstantiateAsync(keyArr[k], parent);
                taskArr[k] = hdlArr[k].Task;
            }
            await Task.WhenAll(taskArr);
            for (byte k = 0; k < keyArr.Length; k++) {
                objArr[k] = hdlArr[k].Result;
            }
            insted(objArr);
        }

        public void Rls<TObj>(TObj obj, CB rlsed = null) {
            Addressables.Release<TObj>(obj);
            if (rlsed != null) {
                rlsed();
            }
        }

        public void Rls<TObj>(TObj[] objArr, CB rlsed = null) {
            for (ushort o = 0; o < objArr.Length; o++) {
                Addressables.Release<TObj>(objArr[o]);
            }
            if (rlsed != null) {
                rlsed();
            }
        }

        // private ushort[] RmvExst(ushort[] orgArr) {
        //     ushort[] newArr = new ushort[0];
        //     for (ushort o = 0; o < orgArr.Length; o++) {
        //         if (_resArr[orgArr[o]][1] == null) {
        //             newArr = Arr.Affx<ushort>(newArr, orgArr[o]);
        //         }
        //     }
        //     return newArr;
        // }
    }
}