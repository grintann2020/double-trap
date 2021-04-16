namespace T {

    public struct SCamPrj {

        public bool OP; // orthographic - Is the camera orthographic (true) or perspective (false)?
        public float OPSize;  // orthographicSize - Camera's half-size when in orthographic mode.
        public float FOV; // fieldOfView - The field of view of the camera in degrees.
        public bool PhyCam; // usePhysicalProperties - Enable [UsePhysicalProperties] to use physical camera properties to compute the field of view and the frustum.
        public float Near; // nearClipPlane - The distance of the near clipping plane from the the Camera, in world units.
        public float Far; // farClipPlane - The distance of the far clipping plane from the Camera, in world units.
        // public bool FOVAxis; // FieldOfViewAxis

        public SCamPrj(bool op, float opSize, float fov, bool phyCam, float near, float far /*, bool fovAxis */) {
            OP = op;
            OPSize =  op ? opSize : float.NaN;
            FOV = op ? float.NaN : fov;
            PhyCam = op ? false : phyCam;
            Near = near;
            Far = far;
            // FOVAxis = fovAxis;
        }
    }
}