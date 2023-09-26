using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Linf02IL()
        {
            if (ArchitectureZeroTen.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            var roth = (ArchitectureZeroTen.ArgumentArray.Length - 1);

            var eoth = ArchitectureZeroTen.ArgumentArray[roth];

            var lower = eoth.ToLower();

            Boolean isLingerCheck, shouldReturn;

            isLingerCheck = lower.Equals("linger") is true;

            shouldReturn = isLingerCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            ArchitectureZeroTen.HasLinger = true;

            return;
        }
    }
}
