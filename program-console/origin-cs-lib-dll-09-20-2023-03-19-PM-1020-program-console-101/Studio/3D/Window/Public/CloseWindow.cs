using Core;

namespace Core
{
    using System;

    public partial class Window
    {
        public static void CloseWindow()
        {
            SpecializeConsoleLJ.GetConsoleLJInstance().Running(false);

            Instance.Hide();

            Instance.Close();

            return;
        }
    }
}
