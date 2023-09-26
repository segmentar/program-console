using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJSequence
    {
        public ConsoleLJ Result { get; set; } = default;

        public ConsoleLJSequence(Boolean debug)
        {
            Debug(debug);

            ConsoleLJ consoleLJ;

            consoleLJ = new ConsoleLJ(debug);

            this.Result = consoleLJ;

            return;
        }

        ~ConsoleLJSequence()
        {
            return;
        }
    }
}
