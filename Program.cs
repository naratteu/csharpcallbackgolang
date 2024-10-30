using System.Runtime.InteropServices;

Invoke(() => Console.WriteLine("Hello from C# delegate!"));
Wrapper.Invoke(() => Console.WriteLine("Hello from C# delegate! 2"));
Wrapper.Invoke2(i => Console.WriteLine($"Hello from C# delegate! {i}"), 3);
Console.WriteLine($"Hello from C# delegate! {Wrapper.Invoke3(() => 4)}");

[DllImport("csharpcallbackgolang.so", CallingConvention = CallingConvention.Cdecl)]
static extern void Invoke(Action callback);

static partial class Wrapper
{
    [LibraryImport("csharpcallbackgolang.so")]
    //[UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    public static partial void Invoke(Action callback);

    [LibraryImport("csharpcallbackgolang.so")]
    public static partial void Invoke2(Action2 callback, int i);
    public delegate void Action2(int i);

    [LibraryImport("csharpcallbackgolang.so")]
    public static partial int Invoke3(Funci callback);
    public delegate int Funci();
}