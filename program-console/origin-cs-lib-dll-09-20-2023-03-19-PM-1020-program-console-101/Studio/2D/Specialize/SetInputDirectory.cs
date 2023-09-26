using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static void SetInputDirectory(String inputDirectory, Boolean useEscape, Boolean hasInputDirectory)
        {
            if (useEscape is true)
            {
                inputDirectory = ConsoleLJ.ConsoleLJEscapeJoinDispenserCompound(inputDirectory, ArchitectureZeroTen.EscapeCharacter);
            }
            else
                "false".ToString();

            ArchitectureZeroTen.InputDirectory = inputDirectory;

            ArchitectureZeroTen.HasInputDirectory = hasInputDirectory;

            return;
        }
    }
}
