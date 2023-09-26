using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public ConsoleLJ(Boolean debug)
        {
            ConsoleLJData data;

            data = new ConsoleLJData();

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
