using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJSequence
    {
        public ConsoleLJ Result { get; set; } = default;

        public ConsoleLJSequence(Boolean running, Boolean debug)
        {
            Debug(running, debug);

            ConsoleLJ consoleLJ;

            consoleLJ = new ConsoleLJ(running, debug);

            this.Result = consoleLJ;

            return;
        }

        ~ConsoleLJSequence()
        {
            return;
        }
    }
}
