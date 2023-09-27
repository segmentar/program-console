using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.IO;

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

            if (Directory.Exists(outputDirectory))
            {
                ArchitectureZeroTen.HasValidOutputDirectory = true;
            }
            else
            {
                ArchitectureZeroTen.HasValidOutputDirectory = false;
            }

            return;
        }
    }
}
