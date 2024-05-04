using System.Runtime.InteropServices;

namespace Raylib_CSharp.Rendering.Gl;

[StructLayout(LayoutKind.Sequential)]
public struct VertexBuffer {

    /// <summary>
    /// Number of elements in the buffer (QUADS).
    /// </summary>
    public int ElementCount;

    /// <summary>
    /// Vertex position (XYZ - 3 components per vertex) (shader-location = 0).
    /// </summary>
    public unsafe Span<float> Vertices => new(this.VerticesPtr, this.ElementCount * 3 * 4);

    public unsafe float* VerticesPtr;

    /// <summary>
    /// Vertex texture coordinates (UV - 2 components per vertex) (shader-location = 1).
    /// </summary>
    public unsafe Span<float> TexCoords => new(this.TexCoordsPtr, this.ElementCount * 2 * 4);

    public unsafe float* TexCoordsPtr;

    /// <summary>
    /// Vertex colors (RGBA - 4 components per vertex) (shader-location = 3).
    /// </summary>
    public unsafe Span<byte> Colors => new(this.ColorsPtr, this.ElementCount * 4 * 4);

    public unsafe byte* ColorsPtr;

    /// <summary>
    /// Vertex indices (in case vertex data comes indexed) (6 indices per quad).
    /// </summary>
    public unsafe Span<nint> Indices => new(this.ColorsPtr, this.ElementCount * 6);

    public nint IndicesPtr;

    /// <summary>
    /// OpenGL Vertex Array Object id.
    /// </summary>
    public uint VaoId;

    /// <summary>
    /// OpenGL Vertex Buffer Objects id (5 types of vertex data).
    /// </summary>
    public unsafe Span<uint> VboId {
        get {
            fixed (uint* idPtr = this.VboIdPtr) {
                return new(idPtr, 4);
            }
        }
    }

    public unsafe fixed uint VboIdPtr[4];
}