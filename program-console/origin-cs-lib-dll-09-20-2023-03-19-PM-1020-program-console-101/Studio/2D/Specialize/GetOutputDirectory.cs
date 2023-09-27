using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static String GetOutputDirectory()
        {
            String stringResult = default;

            var boolean_safe_RETURN_should = false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || ArchitectureZeroTen.HasOutputDirectory is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || ArchitectureZeroTen.HasValidOutputDirectory is false;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is true;

            if (shouldReturnCheck is true)
            {
                return stringResult;
            }
            else
                "false".ToString();

            String outputDirectory;

            outputDirectory = ArchitectureZeroTen.OutputDirectory;

            stringResult = outputDirectory;

            return stringResult;
        }
    }
}
