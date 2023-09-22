using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class Window
    {
        public static void CloseWindow()
        {
            ArchitectureOneFirst.Instance.Data.IsRunning = false;

            Instance.Hide();

            Instance.Close();

            return;
        }
    }
}
