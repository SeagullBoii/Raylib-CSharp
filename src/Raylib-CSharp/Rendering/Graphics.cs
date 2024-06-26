using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Camera.Cam2D;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Collision;
using Raylib_CSharp.Fonts;
using Raylib_CSharp.Geometry;
using Raylib_CSharp.Materials;
using Raylib_CSharp.Shaders;
using Raylib_CSharp.Textures;
using Raylib_CSharp.Vr;
using Color = Raylib_CSharp.Colors.Color;

namespace Raylib_CSharp.Rendering;

public static partial class Graphics {

    /// <summary>
    /// Set background color (framebuffer clear color).
    /// </summary>
    /// <param name="color">The color to clear the background with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearBackground(Color color);

    /// <summary>
    /// Setup canvas (framebuffer) to start drawing.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginDrawing();

    /// <summary>
    /// End canvas drawing and swap buffers (double buffering).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndDrawing();

    /// <summary>
    /// Begin 2D mode with custom camera (2D).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginMode2D(Camera2D camera);

    /// <summary>
    /// Ends 2D mode with custom camera.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndMode2D();

    /// <summary>
    /// Begin 3D mode with custom camera (3D).
    /// </summary>
    /// <param name="camera">The custom camera to be used.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginMode3D(Camera3D camera);

    /// <summary>
    /// Ends 3D mode and returns to default 2D orthographic mode.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndMode3D();

    /// <summary>
    /// Begin drawing to render texture.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginTextureMode(RenderTexture2D target);

    /// <summary>
    /// Ends drawing to render texture.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndTextureMode();

    /// <summary>
    /// Begin custom shader drawing.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginShaderMode(Shader shader);

    /// <summary>
    /// End custom shader drawing (use default shader).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndShaderMode();

    /// <summary>
    /// Begin blending mode (alpha, additive, multiplied, subtract, custom).
    /// </summary>
    /// <param name="mode">The blend mode to be applied.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginBlendMode(BlendMode mode);

    /// <summary>
    /// End blending mode (reset to default: alpha blending).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndBlendMode();

    /// <summary>
    /// Begin scissor mode (define screen area for following drawing).
    /// </summary>
    /// <param name="x">X-coordinate of the scissor rectangle.</param>
    /// <param name="y">Y-coordinate of the scissor rectangle.</param>
    /// <param name="width">Width of the scissor rectangle.</param>
    /// <param name="height">Height of the scissor rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginScissorMode(int x, int y, int width, int height);

    /// <summary>
    /// End scissor mode.
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndScissorMode();

    /// <summary>
    /// Begin stereo rendering (requires VR simulator).
    /// </summary>
    /// <param name="config">The VR stereo configuration.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginVrStereoMode(VrStereoConfig config);

    /// <summary>
    /// End stereo rendering (requires VR simulator).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndVrStereoMode();

    /// <summary>
    /// Swap back buffer with front buffer (screen drawing).
    /// </summary>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SwapScreenBuffer();

    /* --------------------------------- Text Drawing --------------------------------- */

    /// <summary>
    /// Draw current FPS.
    /// </summary>
    /// <param name="posX">The x-coordinate of the position to draw the FPS counter.</param>
    /// <param name="posY">The y-coordinate of the position to draw the FPS counter.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "DrawFPS")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawFps(int posX, int posY);

    /// <summary>
    /// Draw text (using default font).
    /// </summary>
    /// <param name="text">The text string to be drawn.</param>
    /// <param name="posX">The x-coordinate of the starting position of the text.</param>
    /// <param name="posY">The y-coordinate of the starting position of the text.</param>
    /// <param name="fontSize">The font size of the text.</param>
    /// <param name="color">The color of the text.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawText(string text, int posX, int posY, int fontSize, Color color);

    /// <summary>
    /// Draw text using font and additional parameters.
    /// </summary>
    /// <param name="font">The font to use for drawing the text.</param>
    /// <param name="text">The text to draw.</param>
    /// <param name="position">The position of the text.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="spacing">The spacing between characters.</param>
    /// <param name="tint">The color tint to apply to the text.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Draw text using Font and pro parameters (rotation).
    /// </summary>
    /// <param name="font">The font to use for drawing the text.</param>
    /// <param name="text">The text to be drawn.</param>
    /// <param name="position">The position where the text will be drawn on the screen.</param>
    /// <param name="origin">The origin of the text. Defaults to (0, 0).</param>
    /// <param name="rotation">The rotation angle of the text. Defaults to 0.</param>
    /// <param name="fontSize">The size of the font. Defaults to 10.</param>
    /// <param name="spacing">The spacing between characters. Defaults to 0.</param>
    /// <param name="tint">The color to tint the text. Defaults to white (RGB: 255, 255, 255).</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Draw one character (codepoint).
    /// </summary>
    /// <param name="font">The font to use for drawing the codepoint.</param>
    /// <param name="codepoint">The Unicode codepoint to draw.</param>
    /// <param name="position">The position at which to draw the codepoint.</param>
    /// <param name="fontSize">The size of the codepoint to be drawn.</param>
    /// <param name="tint">The tint color to apply to the codepoint.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint);

    /// <summary>
    /// Draw multiple character (codepoint).
    /// </summary>
    /// <param name="font">The font to use for drawing.</param>
    /// <param name="codepoints">An array of codepoints to draw.</param>
    /// <param name="codepointCount">The number of codepoints in the array.</param>
    /// <param name="position">The position to draw the text.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="spacing">The spacing between characters.</param>
    /// <param name="tint">The tint color to apply to the text.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTextCodepoints(Font font, int* codepoints, int codepointCount, Vector2 position, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Draw multiple character (codepoint).
    /// </summary>
    /// <param name="font">The font to use for drawing.</param>
    /// <param name="codepoints">An array of codepoints to draw.</param>
    /// <param name="position">The position to draw the text.</param>
    /// <param name="fontSize">The size of the font.</param>
    /// <param name="spacing">The spacing between characters.</param>
    /// <param name="tint">The tint color to apply to the text.</param>
    public static unsafe void DrawTextCodepoints(Font font, ReadOnlySpan<int> codepoints, Vector2 position, float fontSize, float spacing, Color tint) {
        fixed (int* codepointsPtr = codepoints) {
            DrawTextCodepoints(font, codepointsPtr, codepoints.Length, position, fontSize, spacing, tint);
        }
    }

    /* --------------------------------- Mesh Drawing --------------------------------- */

    /// <summary>
    /// Draw a 3d mesh with material and transform.
    /// </summary>
    /// <param name="mesh">The mesh to draw</param>
    /// <param name="material">The material to use for rendering</param>
    /// <param name="transform">The transformation matrix to apply to the mesh</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawMesh(Mesh mesh, Material material, Matrix4x4 transform);

    /// <summary>
    /// Draw multiple mesh instances with material and different transforms.
    /// </summary>
    /// <param name="mesh">The mesh to be drawn.</param>
    /// <param name="material">The material to be applied to the mesh.</param>
    /// <param name="transforms">An array of transform matrices for each instance.</param>
    /// <param name="instances">The number of instances to be drawn.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawMeshInstanced(Mesh mesh, Material material, Matrix4x4* transforms, int instances);


    /// <summary>
    /// Draw multiple mesh instances with material and different transforms.
    /// </summary>
    /// <param name="mesh">The mesh to be drawn.</param>
    /// <param name="material">The material to be used for rendering.</param>
    /// <param name="transforms">The transforms for each instance.</param>
    public static unsafe void DrawMeshInstanced(Mesh mesh, Material material, Span<Matrix4x4> transforms) {
        fixed (Matrix4x4* transformsPtr = transforms) {
            DrawMeshInstanced(mesh, material, transformsPtr, transforms.Length);
        }
    }

    /* --------------------------------- Model Drawing --------------------------------- */

    /// <summary>
    /// Draw a line in 3D world space.
    /// </summary>
    /// <param name="startPos">The starting position of the line.</param>
    /// <param name="endPos">The ending position of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLine3D(Vector3 startPos, Vector3 endPos, Color color);

    /// <summary>
    /// Draw a point in 3D space, actually a small line.
    /// </summary>
    /// <param name="position">The position of the point in 3D space.</param>
    /// <param name="color">The color of the point.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPoint3D(Vector3 position, Color color);

    /// <summary>
    /// Draw a circle in 3D world space.
    /// </summary>
    /// <param name="center">The center position of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="rotationAxis">The axis to rotate the circle around.</param>
    /// <param name="rotationAngle">The angle in degrees to rotate the circle around the rotation axis.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircle3D(Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color);

    /// <summary>
    /// Draw a color-filled triangle (vertex in counter-clockwise order!).
    /// </summary>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color of the triangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangle3D(Vector3 v1, Vector3 v2, Vector3 v3, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points.
    /// </summary>
    /// <param name="points">The points of the triangle.</param>
    /// <param name="pointCount">The count of the points.</param>
    /// <param name="color">The color to fill the triangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangle3D(Vector3* points, int pointCount, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points.
    /// </summary>
    /// <param name="points">An array of points that represents the triangle vertices in 3D space.</param>
    /// <param name="color">The color of the triangle.</param>
    public static unsafe void DrawTriangle3D(Span<Vector3> points, Color color) {
        fixed (Vector3* pointsPtr = points) {
            DrawTriangle3D(pointsPtr, points.Length, color);
        }
    }

    /// <summary>
    /// Draw cube.
    /// </summary>
    /// <param name="position">The position of the cube.</param>
    /// <param name="width">The width of the cube.</param>
    /// <param name="height">The height of the cube.</param>
    /// <param name="length">The length of the cube.</param>
    /// <param name="color">The color of the cube.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCube(Vector3 position, float width, float height, float length, Color color);

    /// <summary>
    /// Draw cube (Vector version).
    /// </summary>
    /// <param name="position">The position of the cube.</param>
    /// <param name="size">The size of the cube.</param>
    /// <param name="color">The color of the cube.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeV(Vector3 position, Vector3 size, Color color);

    /// <summary>
    /// Draw cube wires.
    /// </summary>
    /// <param name="position">The position of the cube in 3D space.</param>
    /// <param name="width">The width of the cube.</param>
    /// <param name="height">The height of the cube.</param>
    /// <param name="length">The length of the cube.</param>
    /// <param name="color">The color of the cube.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeWires(Vector3 position, float width, float height, float length, Color color);

    /// <summary>
    /// Draw cube wires (Vector version).
    /// </summary>
    /// <param name="position">The position of the cube.</param>
    /// <param name="size">The size of the cube.</param>
    /// <param name="color">The color of the cube wires.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeWiresV(Vector3 position, Vector3 size, Color color);

    /// <summary>
    /// Draw sphere.
    /// </summary>
    /// <param name="centerPos">The center position of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="color">The color of the sphere.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphere(Vector3 centerPos, float radius, Color color);

    /// <summary>
    /// Draw sphere with extended parameters.
    /// </summary>
    /// <param name="centerPos">The center position of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="rings">The number of rings in the sphere. The higher the number, the smoother the surface.</param>
    /// <param name="slices">The number of slices in the sphere. The higher the number, the more detailed the sphere is.</param>
    /// <param name="color">The color of the sphere.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphereEx(Vector3 centerPos, float radius, int rings, int slices, Color color);

    /// <summary>
    /// Draw sphere wires.
    /// </summary>
    /// <param name="centerPos">The position of the center of the sphere.</param>
    /// <param name="radius">The radius of the sphere.</param>
    /// <param name="rings">The number of horizontal rings that make up the sphere.</param>
    /// <param name="slices">The number of vertical slices that make up the sphere.</param>
    /// <param name="color">The color of the sphere.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphereWires(Vector3 centerPos, float radius, int rings, int slices, Color color);

    /// <summary>
    /// Draw a cylinder/cone.
    /// </summary>
    /// <param name="position">The position of the center of the cylinder.</param>
    /// <param name="radiusTop">The radius of the top surface of the cylinder.</param>
    /// <param name="radiusBottom">The radius of the bottom surface of the cylinder.</param>
    /// <param name="height">The height of the cylinder.</param>
    /// <param name="slices">The number of subdivisions around the circumference of the cylinder.</param>
    /// <param name="color">The color of the cylinder.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

    /// <summary>
    /// Draw a cylinder with base at startPos and top at endPos.
    /// </summary>
    /// <param name="startPos">The starting position of the cylinder.</param>
    /// <param name="endPos">The ending position of the cylinder.</param>
    /// <param name="startRadius">The radius of the cylinder at the starting position.</param>
    /// <param name="endRadius">The radius of the cylinder at the ending position.</param>
    /// <param name="sides">The number of sides (segments) that make up the cylinder.</param>
    /// <param name="color">The color of the cylinder.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

    /// <summary>
    /// Draw a cylinder/cone wires.
    /// </summary>
    /// <param name="position">The position of the center of the cylinder.</param>
    /// <param name="radiusTop">The radius of the top circle of the cylinder.</param>
    /// <param name="radiusBottom">The radius of the bottom circle of the cylinder.</param>
    /// <param name="height">The height of the cylinder.</param>
    /// <param name="slices">The number of slices used to create the cylinder.</param>
    /// <param name="color">The color of the wireframe.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

    /// <summary>
    /// Draw a cylinder wires with base at startPos and top at endPos.
    /// </summary>
    /// <param name="startPos">The starting position of the cylinder.</param>
    /// <param name="endPos">The ending position of the cylinder.</param>
    /// <param name="startRadius">The radius of the cylinder at the starting position.</param>
    /// <param name="endRadius">The radius of the cylinder at the ending position.</param>
    /// <param name="sides">The number of sides of the cylinder.</param>
    /// <param name="color">The color of the cylinder.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderWiresEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

    /// <summary>
    /// Draw a capsule with the center of its sphere caps at startPos and endPos.
    /// </summary>
    /// <param name="startPos">The start position of the capsule.</param>
    /// <param name="endPos">The end position of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="slices">The number of slices used to form the capsule geometry.</param>
    /// <param name="rings">The number of rings used to form the capsule geometry.</param>
    /// <param name="color">The color of the capsule.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCapsule(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);

    /// <summary>
    /// Draw capsule wireframe with the center of its sphere caps at startPos and endPos.
    /// </summary>
    /// <param name="startPos">The start position of the capsule.</param>
    /// <param name="endPos">The end position of the capsule.</param>
    /// <param name="radius">The radius of the capsule.</param>
    /// <param name="slices">The number of slices used to draw the capsule.</param>
    /// <param name="rings">The number of rings used to draw the capsule.</param>
    /// <param name="color">The color of the capsule wires.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCapsuleWires(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);

    /// <summary>
    /// Draw a plane XZ.
    /// </summary>
    /// <param name="centerPos">The center position of the plane.</param>
    /// <param name="size">The size of the plane, specified as a 2D vector.</param>
    /// <param name="color">The color of the plane.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPlane(Vector3 centerPos, Vector2 size, Color color);

    /// <summary>
    /// Draw a ray line.
    /// </summary>
    /// <param name="ray">The ray to draw.</param>
    /// <param name="color">The color of the ray.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRay(Ray ray, Color color);

    /// <summary>
    /// Draw a grid (centered at (0, 0, 0)).
    /// </summary>
    /// <param name="slices">The number of subdivisions per side of the grid.</param>
    /// <param name="spacing">The spacing between grid lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawGrid(int slices, float spacing);

    /// <summary>
    /// Draw a model (with texture if set).
    /// </summary>
    /// <param name="model">The model to be drawn.</param>
    /// <param name="position">The position where the model should be drawn.</param>
    /// <param name="scale">The scaling factor to apply to the model.</param>
    /// <param name="tint">The color tint to apply to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModel(Model model, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Draw a model with extended parameters.
    /// </summary>
    /// <param name="model">The model to be drawn.</param>
    /// <param name="position">The position of the model.</param>
    /// <param name="rotationAxis">The axis to rotate the model around.</param>
    /// <param name="rotationAngle">The angle of rotation in degrees.</param>
    /// <param name="scale">The scale factor applied to the model.</param>
    /// <param name="tint">The color tint to be applied to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    /// <summary>
    /// Draw a model wires (with texture if set).
    /// </summary>
    /// <param name="model">The model to draw the wires of.</param>
    /// <param name="position">The position at which to draw the model.</param>
    /// <param name="scale">The scale at which to draw the model.</param>
    /// <param name="tint">The tint color to apply to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelWires(Model model, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Draw a model wires (with texture if set) with extended parameters.
    /// </summary>
    /// <param name="model">The model to draw.</param>
    /// <param name="position">The position to place the model.</param>
    /// <param name="rotationAxis">The rotation axis to apply to the model.</param>
    /// <param name="rotationAngle">The rotation angle to apply to the model.</param>
    /// <param name="scale">The scale to apply to the model.</param>
    /// <param name="tint">The color tint to apply to the model.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelWiresEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    /// <summary>
    /// Draw bounding box (wires).
    /// </summary>
    /// <param name="box">The bounding box to draw.</param>
    /// <param name="color">The color of the bounding box.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBoundingBox(BoundingBox box, Color color);

    /// <summary>
    /// Draw a billboard texture.
    /// </summary>
    /// <param name="camera">The camera used for rendering.</param>
    /// <param name="texture">The texture to be drawn as a billboard.</param>
    /// <param name="position">The position of the billboard in 3D space.</param>
    /// <param name="size">The size of the billboard.</param>
    /// <param name="tint">The tint color of the billboard.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboard(Camera3D camera, Texture2D texture, Vector3 position, float size, Color tint);

    /// <summary>
    /// Draw a billboard texture defined by source.
    /// </summary>
    /// <param name="camera">The camera in 3D space.</param>
    /// <param name="texture">The texture of the billboard.</param>
    /// <param name="source">The source rectangle from the texture to be used for the billboard.</param>
    /// <param name="position">The position of the billboard in 3D space.</param>
    /// <param name="size">The size of the billboard.</param>
    /// <param name="tint">The tint color to be applied to the billboard.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboardRec(Camera3D camera, Texture2D texture, Rectangle source, Vector3 position, Vector2 size, Color tint);

    /// <summary>
    /// Draw a billboard texture defined by source and rotation.
    /// </summary>
    /// <param name="camera">The camera used for drawing.</param>
    /// <param name="texture">The texture used for the billboard.</param>
    /// <param name="source">The source rectangle of the texture.</param>
    /// <param name="position">The position of the billboard in 3D space.</param>
    /// <param name="up">The up direction of the billboard.</param>
    /// <param name="size">The size of the billboard.</param>
    /// <param name="origin">The origin of the billboard.</param>
    /// <param name="rotation">The rotation of the billboard.</param>
    /// <param name="tint">The color tint of the billboard.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboardPro(Camera3D camera, Texture2D texture, Rectangle source, Vector3 position, Vector3 up, Vector2 size, Vector2 origin, float rotation, Color tint);

    /* --------------------------------- Shape Drawing --------------------------------- */

    /// <summary>
    /// Set texture and rectangle to be used on shapes drawing.
    /// </summary>
    /// <param name="texture">The texture to set.</param>
    /// <param name="source">The source rectangle of the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetShapesTexture(Texture2D texture, Rectangle source);

    /// <summary>
    /// Draw a pixel.
    /// </summary>
    /// <param name="posX">The X coordinate of the pixel position.</param>
    /// <param name="posY">The Y coordinate of the pixel position.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPixel(int posX, int posY, Color color);

    /// <summary>
    /// Draw a pixel (Vector version).
    /// </summary>
    /// <param name="position">The position of the pixel.</param>
    /// <param name="color">The color of the pixel.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPixelV(Vector2 position, Color color);

    /// <summary>
    /// Draw a line.
    /// </summary>
    /// <param name="startPosX">The x-coordinate of the starting point.</param>
    /// <param name="startPosY">The y-coordinate of the starting point.</param>
    /// <param name="endPosX">The x-coordinate of the ending point.</param>
    /// <param name="endPosY">The y-coordinate of the ending point.</param>
    /// <param name="color">The color to use for drawing the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color);

    /// <summary>
    /// Draw a line (using gl lines).
    /// </summary>
    /// <param name="startPos">The starting position of the line.</param>
    /// <param name="endPos">The ending position of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineV(Vector2 startPos, Vector2 endPos, Color color);

    /// <summary>
    /// Draw a line (using triangles/quads).
    /// </summary>
    /// <param name="startPos">The starting position of the line.</param>
    /// <param name="endPos">The ending position of the line.</param>
    /// <param name="thick">The thickness of the line.</param>
    /// <param name="color">The color of the line.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Color color);

    /// <summary>
    /// Draw lines sequence (using gl lines).
    /// </summary>
    /// <param name="points">The array of points defining the line strip.</param>
    /// <param name="pointCount">The number of points in the line strip array.</param>
    /// <param name="color">The color of the line strip.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawLineStrip(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw lines sequence (using gl lines).
    /// </summary>
    /// <param name="points">The array of points defining the line strip.</param>
    /// <param name="color">The color of the line strip.</param>
    public static unsafe void DrawLineStrip(Span<Vector2> points, Color color) {
        fixed (Vector2* pointsPtr = points) {
            DrawLineStrip(pointsPtr, points.Length, color);
        }
    }

    /// <summary>
    /// Draw line segment cubic-bezier in-out interpolation.
    /// </summary>
    /// <param name="startPos">The starting position of the curve.</param>
    /// <param name="endPos">The ending position of the curve.</param>
    /// <param name="thick">The thickness of the curve.</param>
    /// <param name="color">The color of the curve.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Color color);

    /// <summary>
    /// Draw a color-filled circle.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the center of the circle.</param>
    /// <param name="centerY">The y-coordinate of the center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircle(int centerX, int centerY, float radius, Color color);

    /// <summary>
    /// Draw a piece of a circle.
    /// </summary>
    /// <param name="center">The center point of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="startAngle">The starting angle of the sector in degrees.</param>
    /// <param name="endAngle">The ending angle of the sector in degrees.</param>
    /// <param name="segments">The number of line segments used to approximate the curve.</param>
    /// <param name="color">The color to fill the sector with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw circle sector outline.
    /// </summary>
    /// <param name="center">The center point of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="startAngle">The start angle in radians.</param>
    /// <param name="endAngle">The end angle in radians.</param>
    /// <param name="segments">The number of line segments to use.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw a gradient-filled circle.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the circle's center.</param>
    /// <param name="centerY">The y-coordinate of the circle's center.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color1">The color at the center of the circle.</param>
    /// <param name="color2">The color at the edge of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleGradient(int centerX, int centerY, float radius, Color color1, Color color2);

    /// <summary>
    /// Draw a color-filled circle (Vector version).
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleV(Vector2 center, float radius, Color color);

    /// <summary>
    /// Draw circle outline.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the center of the circle.</param>
    /// <param name="centerY">The y-coordinate of the center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleLines(int centerX, int centerY, float radius, Color color);

    /// <summary>
    /// Draw circle outline (Vector version).
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="color">The color of the circle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleLinesV(Vector2 center, float radius, Color color);

    /// <summary>
    /// Draw ellipse.
    /// </summary>
    /// <param name="centerX">The X coordinate of the center of the ellipse.</param>
    /// <param name="centerY">The Y coordinate of the center of the ellipse.</param>
    /// <param name="radiusH">The horizontal radius of the ellipse.</param>
    /// <param name="radiusV">The vertical radius of the ellipse.</param>
    /// <param name="color">The color of the ellipse.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color);

    /// <summary>
    /// Draw ellipse outline.
    /// </summary>
    /// <param name="centerX">The x-coordinate of the center of the ellipse.</param>
    /// <param name="centerY">The y-coordinate of the center of the ellipse.</param>
    /// <param name="radiusH">The horizontal radius of the ellipse.</param>
    /// <param name="radiusV">The vertical radius of the ellipse.</param>
    /// <param name="color">The color of the ellipse outline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color);

    /// <summary>
    /// Draw ring.
    /// </summary>
    /// <param name="center">The center of the ring.</param>
    /// <param name="innerRadius">The inner radius of the ring.</param>
    /// <param name="outerRadius">The outer radius of the ring.</param>
    /// <param name="startAngle">The start angle of the ring (in radians).</param>
    /// <param name="endAngle">The end angle of the ring (in radians).</param>
    /// <param name="segments">The number of segments to draw the ring.</param>
    /// <param name="color">The color of the ring.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw ring outline.
    /// </summary>
    /// <param name="center">The center point of the ring.</param>
    /// <param name="innerRadius">The inner radius of the ring.</param>
    /// <param name="outerRadius">The outer radius of the ring.</param>
    /// <param name="startAngle">The start angle of the ring in radians.</param>
    /// <param name="endAngle">The end angle of the ring in radians.</param>
    /// <param name="segments">The number of line segments which form the ring.</param>
    /// <param name="color">The color of the ring.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw a color-filled rectangle.
    /// </summary>
    /// <param name="posX">The x-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="posY">The y-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangle(int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw a color-filled rectangle (Vector version).
    /// </summary>
    /// <param name="position">The position of the top-left corner of the rectangle.</param>
    /// <param name="size">The size of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleV(Vector2 position, Vector2 size, Color color);

    /// <summary>
    /// Draw a color-filled rectangle.
    /// </summary>
    /// <param name="rec"> The dimensions of the rectangle to draw.</param>
    /// <param name="color"> The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRec(Rectangle rec, Color color);

    /// <summary>
    /// Draw a color-filled rectangle with pro parameters.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="origin">The origin point of rotation.</param>
    /// <param name="rotation">The rotation angle in degrees.</param>
    /// <param name="color">The color to fill the rectangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectanglePro(Rectangle rec, Vector2 origin, float rotation, Color color);

    /// <summary>
    /// Draw a vertical-gradient-filled rectangle.
    /// </summary>
    /// <param name="posX">The X coordinate of the rectangle's top-left corner.</param>
    /// <param name="posY">The Y coordinate of the rectangle's top-left corner.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color1">The starting color of the gradient.</param>
    /// <param name="color2">The ending color of the gradient.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientV(int posX, int posY, int width, int height, Color color1, Color color2);

    /// <summary>
    /// Draw a horizontal-gradient-filled rectangle.
    /// </summary>
    /// <param name="posX">The starting x-coordinate of the rectangle.</param>
    /// <param name="posY">The starting y-coordinate of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color1">The starting color of the gradient.</param>
    /// <param name="color2">The ending color of the gradient.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientH(int posX, int posY, int width, int height, Color color1, Color color2);

    /// <summary>
    /// Draw a gradient-filled rectangle with custom vertex colors.
    /// </summary>
    /// <param name="rec">The position and size of the rectangle.</param>
    /// <param name="col1">The color at the top-left corner of the rectangle.</param>
    /// <param name="col2">The color at the top-right corner of the rectangle.</param>
    /// <param name="col3">The color at the bottom-right corner of the rectangle.</param>
    /// <param name="col4">The color at the bottom-left corner of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientEx(Rectangle rec, Color col1, Color col2, Color col3, Color col4);

    /// <summary>
    /// Draw rectangle outline.
    /// </summary>
    /// <param name="posX">The x-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="posY">The y-coordinate of the top-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleLines(int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw rectangle outline with extended parameters.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="lineThick">The thickness of the lines in pixels.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleLinesEx(Rectangle rec, float lineThick, Color color);

    /// <summary>
    /// Draw rectangle with rounded edges.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="roundness">The roundness of the rectangle corners.</param>
    /// <param name="segments">The number of segments used to draw the rounded corners.</param>
    /// <param name="color">The color of the rectangle.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRounded(Rectangle rec, float roundness, int segments, Color color);

    /// <summary>
    /// Draw rectangle with rounded edges outline.
    /// </summary>
    /// <param name="rec">The rectangle to draw.</param>
    /// <param name="roundness">The roundness of the corners. The value 0 is a sharp corner, while larger values make the corners more rounded.</param>
    /// <param name="segments">The number of segments used to approximate each corner.</param>
    /// <param name="lineThick">The thickness of the lines used to draw the rectangle and its corners.</param>
    /// <param name="color">The color of the rectangle and its corners.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRoundedLines(Rectangle rec, float roundness, int segments, float lineThick, Color color);

    /// <summary>
    /// Draw triangle outline (vertex in counter-clockwise order!).
    /// </summary>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color to fill the triangle with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw triangle outline (vertex in counter-clockwise order!).
    /// </summary>
    /// <param name="v1">The first vertex of the triangle.</param>
    /// <param name="v2">The second vertex of the triangle.</param>
    /// <param name="v3">The third vertex of the triangle.</param>
    /// <param name="color">The color of the lines.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw a triangle fan defined by points (first vertex is the center).
    /// </summary>
    /// <param name="points">An array of points representing the vertices of the triangles.</param>
    /// <param name="pointCount">The number of vertices in the array.</param>
    /// <param name="color">The color of the triangles.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangleFan(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a triangle fan defined by points (first vertex is the center).
    /// </summary>
    /// <param name="points">An array of Vector2 points that define the vertices of the triangle fan.</param>
    /// <param name="color">The color of the triangle fan.</param>
    public static unsafe void DrawTriangleFan(Span<Vector2> points, Color color) {
        fixed (Vector2* pointsPtr = points) {
            DrawTriangleFan(pointsPtr, points.Length, color);
        }
    }

    /// <summary>
    /// Draw a triangle strip defined by points.
    /// </summary>
    /// <param name="points">The array of vertices defining the triangle strip.</param>
    /// <param name="pointCount">The number of vertices in the array.</param>
    /// <param name="color">The color to fill the triangle strip with.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangleStrip(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points.
    /// </summary>
    /// <param name="points">A span of Vector2 points representing the vertices of the triangle strip.</param>
    /// <param name="color">The color to use for the triangle strip.</param>
    public static unsafe void DrawTriangleStrip(Span<Vector2> points, Color color) {
        fixed (Vector2* pointsPtr = points) {
            DrawTriangleStrip(pointsPtr, points.Length, color);
        }
    }

    /// <summary>
    /// Draw a regular polygon (Vector version).
    /// </summary>
    /// <param name="center">The center position of the polygon.</param>
    /// <param name="sides">The number of sides of the polygon.</param>
    /// <param name="radius">The radius of the polygon.</param>
    /// <param name="rotation">The rotation angle of the polygon in degrees.</param>
    /// <param name="color">The color of the polygon.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPoly(Vector2 center, int sides, float radius, float rotation, Color color);

    /// <summary>
    /// Draw a polygon outline of n sides.
    /// </summary>
    /// <param name="center">The center position of the polygon.</param>
    /// <param name="sides">The number of sides of the polygon.</param>
    /// <param name="radius">The radius of the polygon.</param>
    /// <param name="rotation">The rotation angle of the polygon in radians.</param>
    /// <param name="color">The color of the polygon.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Color color);

    /// <summary>
    /// Draw a polygon outline of n sides with extended parameters.
    /// </summary>
    /// <param name="center">The center position of the shape.</param>
    /// <param name="sides">The number of sides of the shape.</param>
    /// <param name="radius">The radius of the shape.</param>
    /// <param name="rotation">The rotation angle of the shape.</param>
    /// <param name="lineThick">The thickness of the lines.</param>
    /// <param name="color">The color of the shape.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Color color);

    /// <summary>
    /// Draw spline: Linear, minimum 2 points.
    /// </summary>
    /// <param name="points">The array of points that define the spline.</param>
    /// <param name="pointCount">The number of points in the array.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineLinear(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Linear, minimum 2 points.
    /// </summary>
    /// <param name="points">The array of points to connect with the spline curve.</param>
    /// <param name="thick">The thickness of the spline curve.</param>
    /// <param name="color">The color of the spline curve.</param>
    public static unsafe void DrawSplineLinear(Span<Vector2> points, float thick, Color color) {
        fixed (Vector2* pointsPtr = points) {
            DrawSplineLinear(pointsPtr, points.Length, thick, color);
        }
    }

    /// <summary>
    /// Draw spline: B-Spline, minimum 4 points.
    /// </summary>
    /// <param name="points">Pointer to the array of control points.</param>
    /// <param name="pointCount">The number of control points in the array.</param>
    /// <param name="thick">The thickness of the curve.</param>
    /// <param name="color">The color of the curve.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBasis(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: B-Spline, minimum 4 points.
    /// </summary>
    /// <param name="points">The control points of the spline basis curve.</param>
    /// <param name="thick">The thickness of the spline basis curve.</param>
    /// <param name="color">The color of the spline basis curve.</param>
    public static unsafe void DrawSplineBasis(Span<Vector2> points, float thick, Color color) {
        fixed (Vector2* pointsPtr = points) {
            DrawSplineBasis(pointsPtr, points.Length, thick, color);
        }
    }

    /// <summary>
    /// Draw spline: Catmull-Rom, minimum 4 points.
    /// </summary>
    /// <param name="points">The array of control points defining the spline.</param>
    /// <param name="pointCount">The number of control points in the array.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineCatmullRom(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Catmull-Rom, minimum 4 points.
    /// </summary>
    /// <param name="points">The array of control points for the spline.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    public static unsafe void DrawSplineCatmullRom(Span<Vector2> points, float thick, Color color) {
        fixed (Vector2* pointsPtr = points) {
            DrawSplineCatmullRom(pointsPtr, points.Length, thick, color);
        }
    }

    /// <summary>
    /// Draw spline: Quadratic Bezier, minimum 3 points (1 control point): [p1, c2, p3, c4...].
    /// </summary>
    /// <param name="points">The array of control points defining the spline.</param>
    /// <param name="pointCount">The number of control points in the array.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBezierQuadratic(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Quadratic Bezier, minimum 3 points (1 control point): [p1, c2, p3, c4...].
    /// </summary>
    /// <param name="points">The control points of the spline.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    public static unsafe void DrawSplineBezierQuadratic(Span<Vector2> points, float thick, Color color) {
        fixed (Vector2* pointsPtr = points) {
            DrawSplineBezierQuadratic(pointsPtr, points.Length, thick, color);
        }
    }

    /// <summary>
    /// Draw spline: Cubic Bezier, minimum 4 points (2 control points): [p1, c2, c3, p4, c5, c6...].
    /// </summary>
    /// <param name="points">Pointer to an array of Vector2 control points</param>
    /// <param name="pointCount">Number of control points in the array</param>
    /// <param name="thick">Thickness of the curve</param>
    /// <param name="color">Color of the curve</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBezierCubic(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Cubic Bezier, minimum 4 points (2 control points): [p1, c2, c3, p4, c5, c6...].
    /// </summary>
    /// <param name="points">The array of control points that define the spline.</param>
    /// <param name="thick">The thickness of the spline.</param>
    /// <param name="color">The color of the spline.</param>
    public static unsafe void DrawSplineBezierCubic(Span<Vector2> points, float thick, Color color) {
        fixed (Vector2* pointsPtr = points) {
            DrawSplineBezierCubic(pointsPtr, points.Length, thick, color);
        }
    }

    /// <summary>
    /// Draw spline segment: Linear, 2 points.
    /// </summary>
    /// <param name="p1">The starting point of the spline segment.</param>
    /// <param name="p2">The ending point of the spline segment.</param>
    /// <param name="thick">The thickness of the spline segment.</param>
    /// <param name="color">The color of the spline segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentLinear(Vector2 p1, Vector2 p2, float thick, Color color);

    /// <summary>
    /// Draw spline segment: B-Spline, 4 points.
    /// </summary>
    /// <param name="p1">The first control point.</param>
    /// <param name="p2">The second control point.</param>
    /// <param name="p3">The third control point.</param>
    /// <param name="p4">The fourth control point.</param>
    /// <param name="thick">The thickness of the spline segment.</param>
    /// <param name="color">The color of the spline segment </param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Catmull-Rom, 4 points.
    /// </summary>
    /// <param name="p1">The first point of the spline segment.</param>
    /// <param name="p2">The second point of the spline segment.</param>
    /// <param name="p3">The third point of the spline segment.</param>
    /// <param name="p4">The fourth point of the spline segment.</param>
    /// <param name="thick">The thickness of the spline segment.</param>
    /// <param name="color">The color of the spline segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Quadratic Bezier, 2 points, 1 control point.
    /// </summary>
    /// <param name="p1">The starting point of the segment.</param>
    /// <param name="c2">The control point of the segment.</param>
    /// <param name="p3">The ending point of the segment.</param>
    /// <param name="thick">The thickness of the curve segment.</param>
    /// <param name="color">The color of the curve segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBezierQuadratic(Vector2 p1, Vector2 c2, Vector2 p3, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Cubic Bezier, 2 points, 2 control points.
    /// </summary>
    /// <param name="p1">The starting point of the spline segment.</param>
    /// <param name="c2">The second control point of the spline segment.</param>
    /// <param name="c3">The third control point of the spline segment.</param>
    /// <param name="p4">The ending point of the spline segment.</param>
    /// <param name="thick">The thickness of the spline segment to draw.</param>
    /// <param name="color">The color of the spline segment.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float thick, Color color);

    /* --------------------------------- Texture Drawing --------------------------------- */

    /// <summary>
    /// Draw a Texture2D.
    /// </summary>
    /// <param name="texture">The texture to draw.</param>
    /// <param name="posX">The X coordinate of the position to draw the texture at.</param>
    /// <param name="posY">The Y coordinate of the position to draw the texture at.</param>
    /// <param name="tint">The tint color to apply to the texture (optional).</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTexture(Texture2D texture, int posX, int posY, Color tint);

    /// <summary>
    /// Draw a Texture2D with position defined as Vector2.
    /// </summary>
    /// <param name="texture">The texture to be drawn.</param>
    /// <param name="position">The position where the texture will be drawn.</param>
    /// <param name="tint">The color tint to apply to the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureV(Texture2D texture, Vector2 position, Color tint);

    /// <summary>
    /// Draw a Texture2D with extended parameters.
    /// </summary>
    /// <param name="texture">The texture to draw.</param>
    /// <param name="position">The position where the texture will be drawn.</param>
    /// <param name="rotation">The rotation angle of the texture, in degrees.</param>
    /// <param name="scale">The scale factor to apply to the texture.</param>
    /// <param name="tint">The tint color to apply to the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureEx(Texture2D texture, Vector2 position, float rotation, float scale, Color tint);

    /// <summary>
    /// Draw a part of a texture defined by a rectangle.
    /// </summary>
    /// <param name="texture">The texture to draw.</param>
    /// <param name="source">The source rectangle to draw on the texture.</param>
    /// <param name="position">The position where the texture will be drawn on the screen.</param>
    /// <param name="tint">The color tint to apply to the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureRec(Texture2D texture, Rectangle source, Vector2 position, Color tint);

    /// <summary>
    /// Draw a part of a texture defined by a rectangle with 'pro' parameters.
    /// </summary>
    /// <param name="texture">The texture to be drawn.</param>
    /// <param name="source">The source rectangle inside the texture.</param>
    /// <param name="dest">The destination rectangle on the screen.</param>
    /// <param name="origin">The origin point for rotation and scaling.</param>
    /// <param name="rotation">The rotation angle in degrees.</param>
    /// <param name="tint">The color tint of the texture.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTexturePro(Texture2D texture, Rectangle source, Rectangle dest, Vector2 origin, float rotation, Color tint);

    /// <summary>
    /// Draws a texture (or part of it) that stretches or shrinks nicely.
    /// </summary>
    /// <param name="texture">The texture to be drawn.</param>
    /// <param name="nPatchInfo">The nine-patch information.</param>
    /// <param name="dest">The destination rectangle where the texture will be drawn.</param>
    /// <param name="origin">The origin of the rotation.</param>
    /// <param name="rotation">The rotation angle in degrees.</param>
    /// <param name="tint">The color tint.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureNPatch(Texture2D texture, NPatchInfo nPatchInfo, Rectangle dest, Vector2 origin, float rotation, Color tint);
}