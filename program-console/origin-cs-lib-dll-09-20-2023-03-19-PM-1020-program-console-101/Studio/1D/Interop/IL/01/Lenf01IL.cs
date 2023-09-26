using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Lenf01IL()
        {
            var boolean_safe__MORE_THAN = (ArchitectureZeroTen.ArgumentArray.Length > 0);

            Boolean isLengthCheck, shouldReturn;

            isLengthCheck = boolean_safe__MORE_THAN is true;

            shouldReturn = isLengthCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            ArchitectureZeroTen.HasLength = true;

            return;
        }
    }
}
