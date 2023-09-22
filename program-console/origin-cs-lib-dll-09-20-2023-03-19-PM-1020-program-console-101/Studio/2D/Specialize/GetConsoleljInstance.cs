using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static ConsoleLJ GetConsoleLJInstance()
        {
            ConsoleLJ consoleLJResult = default;

            if (ArchitectureOneFirst.HasInstance is false)
            {
                return consoleLJResult;
            }
            else
                "false".ToString();

            ConsoleLJ consoleLJ;

            consoleLJ = ArchitectureOneFirst.Instance;

            consoleLJResult = consoleLJ;

            return consoleLJResult;
        }
    }
}
