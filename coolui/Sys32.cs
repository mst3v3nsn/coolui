﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace coolui
{
    public class Sys32
    {
        const string Kernel32dll = "Kernel32.Dll";

        [DllImport(Kernel32dll, EntryPoint = "Wow64DisableWow64FsRedirection")]
        public static extern bool DisableWow64FSRedirection(ref IntPtr ptr);

        [DllImport(Kernel32dll, EntryPoint = "Wow64RevertWow64FsRedirection")]
        public static extern bool Wow64RevertWow64FsRedirection(IntPtr ptr);
    }
}
