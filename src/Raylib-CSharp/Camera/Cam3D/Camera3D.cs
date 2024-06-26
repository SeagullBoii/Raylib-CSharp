using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Collision;

namespace Raylib_CSharp.Camera.Cam3D;

[StructLayout(LayoutKind.Sequential)]
public partial struct Camera3D {

    /// <summary>
    /// Camera position.
    /// </summary>
    public Vector3 Position;

    /// <summary>
    /// Camera target it looks-at.
    /// </summary>
    public Vector3 Target;

    /// <summary>
    /// Camera up vector (rotation over its axis).
    /// </summary>
    public Vector3 Up;

    /// <summary>
    /// Camera field-of-view aperture in Y (degrees) in perspective, used as near plane width in orthographic.
    /// </summary>
    public float FovY;

    /// <summary>
    /// Camera projection: CAMERA_PERSPECTIVE or CAMERA_ORTHOGRAPHIC.
    /// </summary>
    public CameraProjection Projection;

    /// <summary>
    /// Represents a 3D camera.
    /// </summary>
    /// <param name="position">Position of the camera.</param>
    /// <param name="target">Target point of the camera.</param>
    /// <param name="up">Up vector of the camera.</param>
    /// <param name="fovY">Vertical field of view angle.</param>
    /// <param name="projection">Projection type of the camera.</param>
    public Camera3D(Vector3 position, Vector3 target, Vector3 up, float fovY, CameraProjection projection) {
        this.Position = position;
        this.Target = target;
        this.Up = up;
        this.FovY = fovY;
        this.Projection = projection;
    }

    /// <summary>
    /// Get a ray trace from mouse position.
    /// </summary>
    /// <param name="mousePosition">The position of the mouse in screen coordinates.</param>
    /// <param name="camera">The camera to use for the ray calculation.</param>
    /// <returns>The ray from the mouse position in world space coordinates.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Ray GetMouseRay(Vector2 mousePosition, Camera3D camera);

    /// <summary>
    /// Get the screen space position for a 3d world space position.
    /// </summary>
    /// <param name="position">The world position to convert.</param>
    /// <param name="camera">The camera to use for the conversion.</param>
    /// <returns>The screen coordinates of the world position.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreen(Vector3 position, Camera3D camera);

    /// <summary>
    /// Get size position for a 3d world space position.
    /// </summary>
    /// <param name="position">The world-space position.</param>
    /// <param name="camera">The camera3D to use for the conversion.</param>
    /// <param name="width">The width of the screen.</param>
    /// <param name="height">The height of the screen.</param>
    /// <returns>The screen-space coordinates as a Vector2.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreenEx(Vector3 position, Camera3D camera, int width, int height);
}

/// <summary>
/// Contains extension methods for the <see cref="Camera3D"/> class.
/// </summary>
public static partial class Camera3DExtensions {

    /// <summary>
    /// Update camera position for selected mode.
    /// </summary>
    /// <param name="camera">The camera to update.</param>
    /// <param name="mode">The camera mode.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateCamera")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void Update_(ref Camera3D camera, CameraMode mode);
    public static void Update(this ref Camera3D camera, CameraMode mode) => Update_(ref camera, mode);

    /// <summary>
    /// Update camera movement/rotation.
    /// </summary>
    /// <param name="camera">The camera to update.</param>
    /// <param name="movement">The movement vector.</param>
    /// <param name="rotation">The rotation vector.</param>
    /// <param name="zoom">The zoom value.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "UpdateCameraPro")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void UpdatePro_(ref Camera3D camera, Vector3 movement, Vector3 rotation, float zoom);
    public static void UpdatePro(this ref Camera3D camera, Vector3 movement, Vector3 rotation, float zoom) => UpdatePro_(ref camera, movement, rotation, zoom);

    /// <summary>
    /// Returns the cameras forward vector (normalized).
    /// </summary>
    /// <param name="camera">The camera to get the forward vector from.</param>
    /// <returns>The forward vector of the camera.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetCameraForward")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Vector3 GetForward_(ref Camera3D camera);
    public static Vector3 GetForward(this ref Camera3D camera) => GetForward_(ref camera);

    /// <summary>
    /// Returns the cameras up vector (normalized).
    /// </summary>
    /// <param name="camera">The camera.</param>
    /// <returns>The "up" vector of the camera.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetCameraUp")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Vector3 GetUp_(ref Camera3D camera);
    public static Vector3 GetUp(this ref Camera3D camera) => GetUp_(ref camera);

    /// <summary>
    /// Returns the cameras right vector (normalized).
    /// </summary>
    /// <param name="camera">The camera to get the right vector from.</param>
    /// <returns>The right vector of the camera.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetCameraRight")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Vector3 GetRight_(ref Camera3D camera);
    public static Vector3 GetRight(this ref Camera3D camera) => GetRight_(ref camera);

    /// <summary>
    /// Moves the camera in its forward direction.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="distance">The distance to move the camera forward.</param>
    /// <param name="moveInWorldPlane">Specifies whether to move the camera in the world plane or camera plane.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "CameraMoveForward")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void MoveForward_(ref Camera3D camera, float distance, [MarshalAs(UnmanagedType.I1)] bool moveInWorldPlane);
    public static void MoveForward(this ref Camera3D camera, float distance, bool moveInWorldPlane) => MoveForward_(ref camera, distance, moveInWorldPlane);

    /// <summary>
    /// Moves the camera in its up direction.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="distance">The distance to move the camera up.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "CameraMoveUp")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void MoveUp_(ref Camera3D camera, float distance);
    public static void MoveUp(this ref Camera3D camera, float distance) => MoveUp_(ref camera, distance);

    /// <summary>
    /// Moves the camera target in its current right direction.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="distance">The distance to move the camera to the right.</param>
    /// <param name="moveInWorldPlane">Move the camera in world plane coordinates (relative to pivot).</param>
    [LibraryImport(Raylib.Name, EntryPoint = "CameraMoveRight")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void MoveRight_(ref Camera3D camera, float distance, [MarshalAs(UnmanagedType.I1)] bool moveInWorldPlane);
    public static void MoveRight(this ref Camera3D camera, float distance, bool moveInWorldPlane) => MoveRight_(ref camera, distance, moveInWorldPlane);

    /// <summary>
    /// Moves the camera position closer/farther to/from the camera target.
    /// </summary>
    /// <param name="camera">The camera to move.</param>
    /// <param name="delta">The time interval.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "CameraMoveToTarget")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void MoveToTarget_(ref Camera3D camera, float delta);
    public static void MoveToTarget(this ref Camera3D camera, float delta) => MoveToTarget_(ref camera, delta);

    /// <summary>
    /// Rotates the camera around its up vector.
    /// </summary>
    /// <param name="camera">The camera to yaw.</param>
    /// <param name="angle">The yaw angle in degrees.</param>
    /// <param name="rotateAroundTarget">If true, the camera will rotate around its target.
    /// If false, it will rotate around its position.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "CameraYaw")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void RotateYaw_(ref Camera3D camera, float angle, [MarshalAs(UnmanagedType.I1)] bool rotateAroundTarget);
    public static void RotateYaw(this ref Camera3D camera, float angle, bool rotateAroundTarget) => RotateYaw_(ref camera, angle, rotateAroundTarget);

    /// <summary>
    /// Rotates the camera around its right vector, pitch is "looking up and down".
    /// </summary>
    /// <param name="camera">The camera to rotate.</param>
    /// <param name="angle">The angle to rotate. Positive values rotate counterclockwise, negative values rotate clockwise.</param>
    /// <param name="lockView">If set to true, the camera view will remain locked (parallel to the ground) during rotation.</param>
    /// <param name="rotateAroundTarget">If set to true, the camera will rotate around the target according to its position and orientation.</param>
    /// <param name="rotateUp">If set to true, the camera will rotate around the World's up vector instead of its local up vector.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "CameraPitch")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void RotatePitch_(ref Camera3D camera, float angle, [MarshalAs(UnmanagedType.I1)] bool lockView, [MarshalAs(UnmanagedType.I1)] bool rotateAroundTarget, [MarshalAs(UnmanagedType.I1)] bool rotateUp);
    public static void RotatePitch(this ref Camera3D camera, float angle, bool lockView, bool rotateAroundTarget, bool rotateUp) => RotatePitch_(ref camera, angle, lockView, rotateAroundTarget, rotateUp);

    /// <summary>
    /// Rotates the camera around its forward vector.
    /// </summary>
    /// <param name="camera">The camera to roll.</param>
    /// <param name="angle">The angle in degrees to roll the camera.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "CameraRoll")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void RotateRoll_(ref Camera3D camera, float angle);
    public static void RotateRoll(this ref Camera3D camera, float angle) => RotateRoll_(ref camera, angle);

    /// <summary>
    /// Returns the camera view matrix.
    /// </summary>
    /// <param name="camera">The camera to get the view matrix from.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "GetCameraViewMatrix")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Matrix4x4 GetViewMatrix_(ref Camera3D camera);
    public static Matrix4x4 GetViewMatrix(this ref Camera3D camera) => GetViewMatrix_(ref camera);

    /// <summary>
    /// Returns the camera projection matrix.
    /// </summary>
    /// <param name="camera">The camera to retrieve the projection matrix from.</param>
    /// <param name="aspect">The aspect ratio of the camera.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "GetCameraProjectionMatrix")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Matrix4x4 GetProjectionMatrix_(ref Camera3D camera, float aspect);
    public static Matrix4x4 GetProjectionMatrix(this ref Camera3D camera, float aspect) => GetProjectionMatrix_(ref camera, aspect);

    /// <summary>
    /// Get camera transform matrix (view matrix).
    /// </summary>
    /// <param name="camera">The camera for which to retrieve the matrix.</param>
    /// <returns>The 4x4 matrix representing the camera's view.</returns>
    [LibraryImport(Raylib.Name, EntryPoint = "GetCameraMatrix")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial Matrix4x4 GetMatrix_(Camera3D camera);
    public static Matrix4x4 GetMatrix(this Camera3D camera) => GetMatrix_(camera);
}