using System;
using System.Runtime.InteropServices;

namespace Primjer02
{
    class Program
    {
        [DllImportAttribute("user32.dll")]
        static extern int MessageBoxA(int i, string s1, string s2, int t);

        static int Main()
        {
            return MessageBoxA(0, "API je pozvan", "Win32", 0);
        }
    }
}
