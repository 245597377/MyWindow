using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MyWindow
{
    class Bridge
    {
        [DllImport(@"MyDll.dll", EntryPoint = "SetForegroundWindowEx, CallingConvention=CallingConvention.Cdecl")]
        extern public static bool SetForegroundWindowEx(char[] chr);

        [DllImport(@"MyDll.dll", EntryPoint = "GetWindowRectEx", CallingConvention = CallingConvention.Cdecl)]
        extern public static bool GetWindowRectEx();

        [DllImport(@"MyDll.dll", EntryPoint = "SetCursorPosEx", CallingConvention = CallingConvention.Cdecl)]
        extern public static bool SetCursorPosEx(int x, int y);

        [DllImport(@"MyDll.dll", EntryPoint = "FindWindowWEx", CallingConvention = CallingConvention.Cdecl)]
        extern public static bool FindWindowWEx(char[] chr);

        [DllImport(@"MyDll.dll", EntryPoint = "InputEx", CallingConvention = CallingConvention.Cdecl)]
        extern public static void InputEx(int key);

        [DllImport(@"MyDll.dll", EntryPoint = "ClickEx", CallingConvention = CallingConvention.Cdecl)]
        extern public static void ClickEx();
    }
}
