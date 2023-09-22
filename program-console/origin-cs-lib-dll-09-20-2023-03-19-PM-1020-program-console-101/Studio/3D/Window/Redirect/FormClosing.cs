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
            Window window;

            window = sender as Window;

            window.Dispose();
        }
    }
}
