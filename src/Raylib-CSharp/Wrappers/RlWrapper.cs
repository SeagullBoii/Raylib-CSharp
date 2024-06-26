using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Raylib_CSharp.Windowing;

namespace Raylib_CSharp.Wrappers;

internal static partial class RlWrapper {

    /// <summary>
    /// Takes a screenshot of current screen (saved a .png).
    /// </summary>
    /// <param name="path">The path where the screenshot should be saved.</param>
    [LibraryImport(Raylib.Name, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void TakeScreenshot(string path);

    /// <summary>
    /// Setup init configuration flags (view FLAGS).
    /// </summary>
    /// <param name="flags">The configuration flags to set. Use the bitwise OR operator to combine multiple flags if needed.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetConfigFlags(ConfigFlags flags);

    /// <summary>
    /// Open URL with default system browser (if available).
    /// </summary>
    /// <param name="url">The URL to open.</param>
    [LibraryImport(Raylib.Name, EntryPoint = "OpenURL", StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void OpenUrl(string url);

    /// <summary>
    /// Set the seed for the random number generator.
    /// </summary>
    /// <param name="seed">The seed value to set.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void SetRandomSeed(uint seed);

    /// <summary>
    /// Get a random value between min and max (both included).
    /// </summary>
    /// <param name="min">The minimum value of the range (inclusive).</param>
    /// <param name="max">The maximum value of the range (inclusive).</param>
    /// <returns>A random integer value between the minimum and maximum values.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial int GetRandomValue(int min, int max);

    /// <summary>
    /// Load random values sequence, no values repeated.
    /// </summary>
    /// <param name="count">The number of random values to generate.</param>
    /// <param name="min">The minimum value in the range (inclusive).</param>
    /// <param name="max">The maximum value in the range (inclusive).</param>
    /// <returns>A pointer to an array of random integers.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial int* LoadRandomSequence(int count, int min, int max);

    /// <summary>
    /// Unload random values sequence.
    /// </summary>
    /// <param name="sequence">Pointer to the array containing the random sequence.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static unsafe partial void UnloadRandomSequence(int* sequence);

    /// <summary>
    /// Internal memory allocator.
    /// </summary>
    /// <param name="size">The size of the memory block to allocate.</param>
    /// <returns>A pointer to the allocated memory block.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial nint MemAlloc(int size);

    /// <summary>
    /// Internal memory reallocator.
    /// </summary>
    /// <param name="ptr">A pointer to the block of memory to be allocate, in bytes..</param>
    /// <param name="size">The size of the memory block to allocate, in bytes.</param>
    /// <returns>A pointer to the allocated memory block.</returns>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial nint MemRealloc(nint ptr, int size);

    /// <summary>
    /// Internal memory free.
    /// </summary>
    /// <param name="ptr">A pointer to the block of memory to be freed.</param>
    [LibraryImport(Raylib.Name)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    internal static partial void MemFree(nint ptr);
}