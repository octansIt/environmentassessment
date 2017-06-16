using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvironmentAssessment.Common
{
    internal class CRegistry
    {

        internal static readonly object HKEY_CLASSES_ROOT = 0x80000000;
        internal static readonly object HKEY_CURRENT_USER = 0x80000001;
        internal static readonly object HKEY_LOCAL_MACHINE = 0x80000002;
        internal static readonly object HKEY_USERS = 0x80000003;

        internal static readonly object KEY_ALL_ACCESS = 0xF003F;
        internal static readonly object KEY_CREATE_LINK = 0x0020;
        internal static readonly object KEY_CREATE_SUB_KEY = 0x0004;
        internal static readonly object KEY_ENUMERATE_SUB_KEYS = 0x0008;
        internal static readonly object KEY_EXECUTE = 0x20019;
        internal static readonly object KEY_NOTIFY = 0x0010;
        internal static readonly object KEY_QUERY_VALUE = 0x0001;
        internal static readonly object KEY_READ = 0x20019;
        internal static readonly object KEY_SET_VALUE = 0x0002;
        internal static readonly object KEY_WOW64_32KEY = 0x0200;
        internal static readonly object KEY_WOW64_64KEY = 0x0100;
        internal static readonly object KEY_WRITE = 0x20006;

    }
}
