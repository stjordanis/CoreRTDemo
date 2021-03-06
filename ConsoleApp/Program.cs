﻿using System.Runtime.InteropServices;

namespace ConsoleApp
{
    class Program
    {
        [DllImport("NativeLibrary.dll", EntryPoint = "add", CallingConvention = CallingConvention.StdCall)]
        public static extern int Add(int a, int b);

        [DllImport("NativeLibrary.dll", EntryPoint = "write_line", CallingConvention = CallingConvention.StdCall)]
        public static extern void WriteLine(string text);

        static void Main(string[] args)
        {
            var result = Add(1, 2);
            WriteLine(result.ToString());
            WriteLine("Hello World!");
        }
    }
}
