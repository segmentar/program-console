using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static void SetNativeString(String nativeString, Boolean hasNativeString)
        {
            ArchitectureZeroTen.NativeString = nativeString;

            ArchitectureZeroTen.HasNativeString = hasNativeString;

            return;
        }
    }
}
