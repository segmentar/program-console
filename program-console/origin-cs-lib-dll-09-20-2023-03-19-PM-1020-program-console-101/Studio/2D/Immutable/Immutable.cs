using Core;

namespace Core.DimensionTwoSecond.ConsoleLJ
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class ImmutableZeroTen
    {
        public static String ProgramName;

        public static String ErrorMessage;

        public static String SettingName;

        public static String SettingExtension;

        public static String WorkingDirectoryName;

        public static String WorkingDirectoryIdentity;

        public static String InputFileName;

        public static String InputExtension;

        public static String OutputFileName;

        public static String OutputExtension;

        static ImmutableZeroTen()
        {
            ProgramName = ConsoleLJDefaultImmutableZeroTen.ProgramNameDefault;

            ErrorMessage = ConsoleLJDefaultImmutableZeroTen.ErrorMessageDefault;

            SettingName = ConsoleLJDefaultImmutableZeroTen.SettingNameDefault;

            SettingExtension = ConsoleLJDefaultImmutableZeroTen.SettingExtensionDefault;

            WorkingDirectoryName = ConsoleLJDefaultImmutableZeroTen.WorkingDirectoryNameDefault;

            WorkingDirectoryIdentity = ConsoleLJDefaultImmutableZeroTen.WorkingDirectoryIdentityDefault;

            InputFileName = ConsoleLJDefaultImmutableZeroTen.InputFileNameDefault;

            InputExtension = ConsoleLJDefaultImmutableZeroTen.InputExtensionDefault;

            OutputFileName = ConsoleLJDefaultImmutableZeroTen.OutputFileNameDefault;

            OutputExtension = ConsoleLJDefaultImmutableZeroTen.OutputExtensionDefault;

            return;
        }
    }
}

namespace Core.DimensionTwoSecond.ConsoleLJ
{
    using System;

    public partial class ImmutableOneFirst
    {
        public static readonly Boolean ShowIcon;

        public static readonly Single Opacity;

        public static readonly String Text;

        static ImmutableOneFirst()
        {
            ShowIcon = ConsoleLJDefaultImmutableOneFirst.ShowIconDefault;

            Opacity = ConsoleLJDefaultImmutableOneFirst.OpacityDefault;

            Text = ConsoleLJDefaultImmutableOneFirst.TextDefault;

            return;
        }
    }
}

namespace Core.DimensionTwoSecond.ConsoleLJ
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ImmutableTwoSecond
    {
        public static readonly String Text;

        public static readonly Boolean Multiline;

        public static readonly Boolean AcceptTab;

        public static readonly Boolean ReadOnly;

        public static readonly Boolean WordWrap;

        public static readonly RichTextBoxScrollBars ScrollBars;

        public static readonly Color BackColor;

        public static readonly Color ForeColor;

        public static readonly FontFamily FontFamily;

        public static readonly Single FontSize;

        public static readonly FontStyle FontStyle;

        static ImmutableTwoSecond()
        {
            Text = ConsoleLJDefaultImmutableTwoSecond.TextDefault;

            Multiline = ConsoleLJDefaultImmutableTwoSecond.MultilineDefault;

            AcceptTab = ConsoleLJDefaultImmutableTwoSecond.AcceptTabDefault;

            ReadOnly = ConsoleLJDefaultImmutableTwoSecond.ReadOnlyDefault;

            WordWrap = ConsoleLJDefaultImmutableTwoSecond.WordWrapDefault;

            ScrollBars = ConsoleLJDefaultImmutableTwoSecond.ScrollBarsDefault;

            BackColor = ConsoleLJDefaultImmutableTwoSecond.BackColorDefault;

            ForeColor = ConsoleLJDefaultImmutableTwoSecond.ForeColorDefault;

            FontFamily = ConsoleLJDefaultImmutableTwoSecond.FontFamilyDefault;

            FontSize = ConsoleLJDefaultImmutableTwoSecond.FontSizeDefault;

            FontStyle = ConsoleLJDefaultImmutableTwoSecond.FontStyleDefault;

            return;
        }
    }
}

namespace Core.DimensionTwoSecond.ConsoleLJ
{
    using System;

    using System.Drawing;

    public partial class ImmutableThreeThird
    {
        public static readonly Color BackColor;

        public static readonly Color ForeColor;

        public static readonly FontFamily FontFamily;

        public static readonly Single FontSize;

        public static readonly FontStyle FontStyle;

        static ImmutableThreeThird()
        {
            BackColor = ConsoleLJDefaultImmutableThreeThird.BackColorDefault;

            ForeColor = ConsoleLJDefaultImmutableThreeThird.ForeColorDefault;

            FontFamily = ConsoleLJDefaultImmutableThreeThird.FontFamilyDefault;

            FontSize = ConsoleLJDefaultImmutableThreeThird.FontSizeDefault;

            FontStyle = ConsoleLJDefaultImmutableThreeThird.FontStyleDefault;

            return;
        }
    }
}
