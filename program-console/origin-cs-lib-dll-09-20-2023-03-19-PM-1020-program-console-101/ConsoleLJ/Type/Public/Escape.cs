using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public void Escape()
        {
            if (Context.ReferencePage.HasWindow is false)
            {
                return;
            }
            else
                "false".ToString();

            Window.CloseWindow();

            return;
        }
    }
}
