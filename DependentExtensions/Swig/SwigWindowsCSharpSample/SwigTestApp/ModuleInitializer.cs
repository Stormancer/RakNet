/// <summary>
/// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
/// </summary>
using System;
using System.Runtime.InteropServices;
public static class ModuleInitializer
{
    [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi)]
    static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)]string lpFileName);
    /// <summary>
    /// Initializes the module.
    /// </summary>
    public static void Initialize()
    {
        if (!Environment.Is64BitProcess)
        {
            var handle = LoadLibrary("x86/RakNet.dll");
        }
        else
        {
            var handle = LoadLibrary("x64/RakNet.dll");
        }
    }
}