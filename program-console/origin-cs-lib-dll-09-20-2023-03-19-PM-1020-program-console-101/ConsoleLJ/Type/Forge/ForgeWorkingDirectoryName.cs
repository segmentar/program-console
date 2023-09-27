using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String ForgeWorkingDirectoryName()
        {
            String stringResult = default;

            var name = $"{ImmutableZeroTen.ProgramName}-{ImmutableZeroTen.WorkingDirectoryName}-{ImmutableZeroTen.WorkingDirectoryIdentity}";

            var lower = name.ToLower();

            var split = lower.Split();

            var join = String.Join('-'.ToString(), split);

            stringResult = join;

            return stringResult;
        }
    }
}
