using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Threading.Tasks;

namespace MyLib
{
    public static class Class1
    {
        [DllImport("MathLib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int a, int b);
        [DllImport("MathLib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Subtrac(int a, int b);
        [DllImport("MathLib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Multiply(int a, int b);
        [DllImport("MathLib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Divide(int a, int b);
    }
}
