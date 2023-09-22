using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Window
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            RedirectKeyDown(this, e);

            base.OnKeyDown(e);
        }
    }
}
