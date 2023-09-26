using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public void Running(Boolean running)
        {
            if (running)
            {
                Data.IsRunning = true;
            }
            else
            {
                Data.IsRunning = false;
            }

            return;
        }
    }
}
