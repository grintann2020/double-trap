using UnityEngine;
using T;

namespace DT {

    public class MenuCam : ICam {

        // public Camera Cam;
        public bool Proj; // projection - orthographic / perspetive
        // public FieldOfViewAxis FieldOfViewAxis.FOVAxis; // FieldOfViewAxis
        public float FOV; // field of view
        public float Near; // nearClipPlane
        public float Far; // farClipPlane

        public void Lens(Camera cam) {

        }
    }
}