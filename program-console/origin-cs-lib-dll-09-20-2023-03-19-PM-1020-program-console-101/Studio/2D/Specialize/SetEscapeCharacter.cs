using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static void SetEscapeCharacter(Char escapeCharacter, Boolean hasEscapeCharacter)
        {
            ArchitectureZeroTen.EscapeCharacter = escapeCharacter;

            ArchitectureZeroTen.HasEscapeCharacter = hasEscapeCharacter;

            return;
        }
    }
}
