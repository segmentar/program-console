using Core;

namespace Core
{
    using System;

    public partial class Window
    {
        public static void RedirectLoad(Object sender, EventArgs e)
        {
            Prompt.Instance.Select();

            return;
        }
    }
}
