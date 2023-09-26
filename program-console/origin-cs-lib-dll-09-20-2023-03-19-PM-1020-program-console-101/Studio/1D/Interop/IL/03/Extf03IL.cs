using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Extf03IL()
        {
            if (ArchitectureZeroTen.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            if (ArchitectureZeroTen.HasLinger)
            {
                ArchitectureZeroTen.IsExternalCall = false;
            }
            else
            {
                ArchitectureZeroTen.IsExternalCall = true;
            }

            return;
        }
    }
}
