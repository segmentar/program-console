using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Window
    {
        public static void RedirectFormClosing(Object sender, FormClosingEventArgs e)
        {
            Instance.Dispose();

            Application.Exit();

            return;
        }
    }
}
