using UnityEngine;
using UnityEngine.Rendering;

namespace T {

    public struct SCamProj {

        // public Camera Cam;
        public bool Proj; // projection - orthographic / perspetive
        // public FieldOfViewAxis FieldOfViewAxis.FOVAxis; // FieldOfViewAxis
        public float FOV; // field of view
        public float Near; // nearClipPlane
        public float Far; // farClipPlane

        public SCamProj(bool proj, float fov, float near, float far) {
            // Cam = cam;
            Proj = proj;
            FOV = fov;
            Near = near;
            Far = far;
        }
        
    }
}