using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public ConsoleLJ(Boolean running, Boolean debug)
        {
            ConsoleLJData data;

            data = new ConsoleLJData();

            if (running is true)
            {
                data.IsRunning = true;
            }
            else
                "false".ToString();

            if (debug is true)
            {
                data.IsDebug = true;
            }
            else
                "false".ToString();

            this.Data = data;

            return;
        }
    }
}
