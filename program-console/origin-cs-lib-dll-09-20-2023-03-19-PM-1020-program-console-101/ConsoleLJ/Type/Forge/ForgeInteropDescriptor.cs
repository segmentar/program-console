using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String ForgeInteropDescriptor()
        {
            String stringResult = default;

            var descriptor = new String[] {

                String.Empty,
                String.Empty + '\t' + '\t' + nameof(ArchitectureZeroTen.EscapeCharacter) + ':' + ' ' + ((ArchitectureZeroTen.EscapeCharacter == default) ? String.Empty : ArchitectureZeroTen.EscapeCharacter.ToString()),
                String.Empty,
                String.Empty + '\t' + '\t' + nameof(ArchitectureZeroTen.HasEscapeCharacter) + ':' + ' ' + ArchitectureZeroTen.HasEscapeCharacter,
                String.Empty,
                String.Empty + '\t' + '\t' + nameof(ArchitectureZeroTen.NativeString) + ':' + ' ' + ArchitectureZeroTen.NativeString,
                String.Empty,
                String.Empty + '\t' + '\t' + nameof(ArchitectureZeroTen.HasNativeString) + ':' + ' ' + ArchitectureZeroTen.HasNativeString,
                String.Empty,
                String.Empty + '\t' + '\t' + nameof(ArchitectureZeroTen.HasInputDirectory) + ':' + ' ' + ArchitectureZeroTen.HasInputDirectory,
                String.Empty,
                String.Empty + '\t' + '\t' + nameof(ArchitectureZeroTen.HasOutputDirectory) + ':' + ' ' + ArchitectureZeroTen.HasOutputDirectory,
                String.Empty,
                String.Empty + '\t' + '\t' + nameof(ArchitectureZeroTen.InputDirectory) + ':' + ' ' + ArchitectureZeroTen.InputDirectory,
                String.Empty,
                String.Empty + '\t' + '\t' + nameof(ArchitectureZeroTen.OutputDirectory) + ':' + ' ' + ArchitectureZeroTen.OutputDirectory,
                String.Empty,
            };

            var join = String.Join('\n'.ToString(), descriptor);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
