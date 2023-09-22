using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Prompt
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            Window.RedirectKeyDown(this, e);

            base.OnKeyDown(e);
        }
    }
}
