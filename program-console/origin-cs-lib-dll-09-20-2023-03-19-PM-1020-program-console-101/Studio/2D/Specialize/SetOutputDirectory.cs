using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static void SetOutputDirectory(String outputDirectory, Boolean useEscape, Boolean hasOutputDirectory)
        {
            if (useEscape is true)
            {
                outputDirectory = ConsoleLJ.ConsoleLJEscapeJoinDispenserCompound(outputDirectory, ArchitectureZeroTen.EscapeCharacter);
            }
            else
                "false".ToString();

            ArchitectureZeroTen.OutputDirectory = outputDirectory;

            ArchitectureZeroTen.HasOutputDirectory = hasOutputDirectory;

            return;
        }
    }
}
