using Core;

namespace Core
{
    using Core.DimensionTwoSecond.ConsoleLJ;
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Window
    {
        public static void RedirectKeyDown(Object sender, KeyEventArgs e)
        {
            var escape = Convert.ToChar(27);

            var enter = Convert.ToChar(13);

            Boolean isEscapeCheck, isEnterCheck;

            isEscapeCheck = e.KeyValue.Equals(escape) is true;

            isEnterCheck = e.KeyValue.Equals(enter) is true;

            if (isEscapeCheck is true)
            {
                CloseWindow();
            }
            else
                "false".ToString();

            var boolean_match_READ_LINE_is = true;

            boolean_match_READ_LINE_is = boolean_match_READ_LINE_is && e.KeyValue.Equals(enter) is true;

            boolean_match_READ_LINE_is = boolean_match_READ_LINE_is && ArchitectureOneFirst.Instance.Data.IsWaiting is true;

            Boolean isReadLineCheck;

            isReadLineCheck = boolean_match_READ_LINE_is is true;

            if (isReadLineCheck is true)
            {
                ArchitectureOneFirst.Instance.Data.IsWaiting = false;
            }
            else
                "false".ToString();

            return;
        }
    }
}
