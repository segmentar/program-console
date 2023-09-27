using Core;

namespace Core.DimensionTwoSecond.ConsoleLJ
{
    using System;

    using System.Collections;

    public partial class ArchitectureZeroTen
    {
        public static String[] ArgumentArray;

        public static Boolean HasLength;

        public static Boolean HasLinger;

        public static Boolean IsExternalCall;

        public static ArrayList ArgumentList;

        public static Boolean HasEscapeCharacter;

        public static Char EscapeCharacter;

        public static Boolean HasNativeString;

        public static String NativeString;

        public static Boolean HasInputDirectory;

        public static Boolean HasValidInputDirectory;

        public static String InputDirectory;

        public static Boolean HasOutputDirectory;

        public static Boolean HasValidOutputDirectory;

        public static String OutputDirectory;

        static ArchitectureZeroTen()
        {
            ArgumentArray = ConsoleLJDefaultArchitectureZeroTen.ArgumentArray;

            HasLength = ConsoleLJDefaultArchitectureZeroTen.HasArgumentLengthDefault;

            HasLinger = ConsoleLJDefaultArchitectureZeroTen.HasLingerDefault;

            IsExternalCall = ConsoleLJDefaultArchitectureZeroTen.IsExternalCallDefault;

            ArgumentList = ConsoleLJDefaultArchitectureZeroTen.ArgumentListDefault;

            HasEscapeCharacter = ConsoleLJDefaultArchitectureZeroTen.HasEscapeCharacterDefault;

            EscapeCharacter = ConsoleLJDefaultArchitectureZeroTen.EscapeCharacterDefault;

            HasNativeString = ConsoleLJDefaultArchitectureZeroTen.HasNativeStringDefault;

            NativeString = ConsoleLJDefaultArchitectureZeroTen.NativeStringDefault;

            HasInputDirectory = ConsoleLJDefaultArchitectureZeroTen.HasInputDirectoryDefault;

            HasValidInputDirectory = ConsoleLJDefaultArchitectureZeroTen.HasValidInputDirectoryDefault;

            InputDirectory = ConsoleLJDefaultArchitectureZeroTen.InputDirectoryDefault;

            HasOutputDirectory = ConsoleLJDefaultArchitectureZeroTen.HasOutputDirectoryDefault;

            HasValidOutputDirectory = ConsoleLJDefaultArchitectureZeroTen.HasValidOutputDirectoryDefault;

            OutputDirectory = ConsoleLJDefaultArchitectureZeroTen.OutputDirectoryDefault;

            return;
        }
    }
}

namespace Core.DimensionTwoSecond.ConsoleLJ
{
    using System;

    using ConsoleLJ = Core.ConsoleLJ;

    public partial class ArchitectureOneFirst
    {
        public static ConsoleLJ Instance;

        public static Boolean HasInstance;

        static ArchitectureOneFirst()
        {
            Instance = ConsoleLJDefaultArchitectureOneFirst.InstanceDefault;

            HasInstance = ConsoleLJDefaultArchitectureOneFirst.HasInstanceDefault;

            return;
        }
    }
}
