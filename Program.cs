using System.Runtime.InteropServices;

Invoke(() => Console.WriteLine("Hello from C# delegate!"));
Wrapper.Invoke(() => Console.WriteLine("Hello from C# delegate! 2"));

[DllImport("csharpcallbackgolang.so", CallingConvention = CallingConvention.Cdecl)]
static extern void Invoke(Action callback);

static partial class Wrapper
{
    [LibraryImport("csharpcallbackgolang.so")]
    //[UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    public static partial void Invoke(Action callback);
}