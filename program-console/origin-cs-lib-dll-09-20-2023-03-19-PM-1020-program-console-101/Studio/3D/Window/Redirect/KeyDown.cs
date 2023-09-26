using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Window
    {
        public static void RedirectKeyDown(Object sender, KeyEventArgs e)
        {
            var escape = Convert.ToChar(27);

            Boolean isEscapeCheck;

            isEscapeCheck = e.KeyValue.Equals(escape) is true;

            if (isEscapeCheck is true)
            {
                CloseWindow();
            }
            else
                "false".ToString();

            var enter = Convert.ToChar(13);

            var boolean_match_READ_LINE_is = true;

            boolean_match_READ_LINE_is = boolean_match_READ_LINE_is && e.KeyValue.Equals(enter) is true;

            boolean_match_READ_LINE_is = boolean_match_READ_LINE_is && SpecializeConsoleLJ.GetConsoleLJInstance().Data.IsWaiting is true;

            Boolean isReadLineCheck;

            isReadLineCheck = boolean_match_READ_LINE_is is true;

            if (isReadLineCheck is true)
            {
                SpecializeConsoleLJ.GetConsoleLJInstance().Waiting(false);
            }
            else
                "false".ToString();

            return;
        }
    }
}
