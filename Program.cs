using System;
using System.Runtime.InteropServices;

public delegate void CallbackDelegate();

public static class Wrapper
{
    [DllImport("csharpcallbackgolang.so", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RegisterCallback2(CallbackDelegate callback);
}

class Program
{
    static void Main()
    {
        CallbackDelegate callback = new CallbackDelegate(Hello);
        Wrapper.RegisterCallback2(callback);
    }

    public static void Hello()
    {
        Console.WriteLine("Hello from C# delegate!");
    }
}
