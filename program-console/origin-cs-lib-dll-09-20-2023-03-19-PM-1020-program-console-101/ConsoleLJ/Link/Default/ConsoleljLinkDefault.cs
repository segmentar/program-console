using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJDefaultArchitectureZeroTen
    {
        public static String[] ArgumentArray;

        public static Boolean HasArgumentLengthDefault;

        public static Boolean HasLingerDefault;

        public static Boolean IsExternalCallDefault;

        public static ArrayList ArgumentListDefault;

        public static Boolean HasEscapeCharacterDefault;

        public static Char EscapeCharacterDefault;

        public static Boolean HasNativeStringDefault;

        public static String NativeStringDefault;

        public static Boolean HasInputDirectoryDefault;

        public static Boolean HasValidInputDirectoryDefault;

        public static String InputDirectoryDefault;

        public static Boolean HasOutputDirectoryDefault;

        public static Boolean HasValidOutputDirectoryDefault;

        public static String OutputDirectoryDefault;

        static ConsoleLJDefaultArchitectureZeroTen()
        {
            ArgumentArray = default(String[]);

            HasArgumentLengthDefault = default(Boolean);

            HasLingerDefault = default(Boolean);

            IsExternalCallDefault = default(Boolean);

            ArgumentListDefault = default(ArrayList);

            HasEscapeCharacterDefault = default(Boolean);

            EscapeCharacterDefault = default(Char);

            HasNativeStringDefault = default(Boolean);

            NativeStringDefault = default(String);

            HasInputDirectoryDefault = default(Boolean);

            HasValidInputDirectoryDefault = default(Boolean);

            InputDirectoryDefault = default(String);

            HasOutputDirectoryDefault = default(Boolean);

            HasValidOutputDirectoryDefault = default(Boolean);

            OutputDirectoryDefault = default(String);

            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class ConsoleLJDefaultArchitectureOneFirst
    {
        public static ConsoleLJ InstanceDefault;

        public static Boolean HasInstanceDefault;

        static ConsoleLJDefaultArchitectureOneFirst()
        {
            InstanceDefault = default(ConsoleLJ);

            HasInstanceDefault = default(Boolean);

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class ConsoleLJDefaultImmutableZeroTen
    {
        public static String ProgramNameDefault;

        public static String ErrorMessageDefault;

        public static String SettingNameDefault;

        public static String SettingExtensionDefault;

        public static String WorkingDirectoryNameDefault;

        public static String WorkingDirectoryIdentityDefault;

        public static String InputFileNameDefault;

        public static String InputExtensionDefault;

        public static String OutputFileNameDefault;

        public static String OutputExtensionDefault;

        static ConsoleLJDefaultImmutableZeroTen()
        {
            ProgramNameDefault = Assembly.GetEntryAssembly().GetName().Name;

            ErrorMessageDefault = "This object just so happened to be a default" + ' ' + '.' + ' ' + ":(";

            SettingNameDefault = "Setting";

            SettingExtensionDefault = "txt";

            WorkingDirectoryNameDefault = "Working Directory";

            WorkingDirectoryIdentityDefault = Path.GetRandomFileName();

            InputFileNameDefault = "Input";

            InputExtensionDefault = "package";

            OutputFileNameDefault = "Output";

            OutputExtensionDefault = "package";

            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class ConsoleLJDefaultImmutableOneFirst
    {
        public static Boolean ShowIconDefault;

        public static Single OpacityDefault;

        public static String TextDefault;

        static ConsoleLJDefaultImmutableOneFirst()
        {
            ShowIconDefault = false;

            OpacityDefault = 0.95F;

            TextDefault = nameof(ConsoleLJ);

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ConsoleLJDefaultImmutableTwoSecond
    {
        public static String TextDefault;

        public static Boolean MultilineDefault;

        public static Boolean AcceptTabDefault;

        public static Boolean ReadOnlyDefault;

        public static Boolean WordWrapDefault;

        public static RichTextBoxScrollBars ScrollBarsDefault;

        public static Color BackColorDefault;

        public static Color ForeColorDefault;

        public static FontFamily FontFamilyDefault;

        public static Single FontSizeDefault;

        public static FontStyle FontStyleDefault;

        static ConsoleLJDefaultImmutableTwoSecond()
        {
            TextDefault = String.Empty;

            MultilineDefault = true;

            AcceptTabDefault = true;

            ReadOnlyDefault = true;

            WordWrapDefault = false;

            ScrollBarsDefault = RichTextBoxScrollBars.ForcedBoth;

            BackColorDefault = Color.Blue;

            ForeColorDefault = Color.Yellow;

            FontFamilyDefault = new FontFamily("Consolas");

            FontSizeDefault = 12.00F;

            FontStyleDefault = FontStyle.Regular;

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Drawing;

    public partial class ConsoleLJDefaultImmutableThreeThird
    {
        public static Color BackColorDefault;

        public static Color ForeColorDefault;

        public static FontFamily FontFamilyDefault;

        public static Single FontSizeDefault;

        public static FontStyle FontStyleDefault;

        static ConsoleLJDefaultImmutableThreeThird()
        {
            BackColorDefault = Color.Black;

            ForeColorDefault = Color.GreenYellow;

            FontFamilyDefault = new FontFamily("Consolas");

            FontSizeDefault = 16.00F;

            FontStyleDefault = FontStyle.Regular;

            return;
        }
    }
}
