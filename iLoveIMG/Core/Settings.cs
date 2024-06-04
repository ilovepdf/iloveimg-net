using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Core
{
    /// <summary>
    ///     ILoveIMG Wrapper settings
    /// </summary>
    internal static class Settings
    {
        public const String StartUrl = @"https://api.iloveimg.com";

        public const String Host = @"https://";

        public const String V1 = @"v1";

        //2MB 2000000
        public const Int32 MaxBytesPerChunk = 2000000;

        public static String NetVersion => FileVersionInfo
            .GetVersionInfo(
#if NETSTANDARD1_5
                typeof(Settings).GetTypeInfo().Assembly.Location
#else
                Assembly.GetExecutingAssembly().Location
#endif
                ).FileVersion;
    }

    internal static class StringHelpers
    {
        internal static String Invariant(String v)
        {
#if NETSTANDARD1_5
            return v;
#else
            return v.ToString(System.Globalization.CultureInfo.InvariantCulture);
#endif
        }
    }
}
