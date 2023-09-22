using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static ConsoleLJ MakeConsoleLJDefaultSurface(Boolean running)
        {
            ConsoleLJ consoleLJResult = default;

            consoleLJResult = MakeConsoleLJDefault(running, ConsoleLJPolicy.ConsoleLJDebugPolicy);
            
            return consoleLJResult;
        }
    }
}
