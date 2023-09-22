using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Window
    {
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            RedirectFormClosing(this, e);

            base.OnFormClosing(e);
        }
    }
}
