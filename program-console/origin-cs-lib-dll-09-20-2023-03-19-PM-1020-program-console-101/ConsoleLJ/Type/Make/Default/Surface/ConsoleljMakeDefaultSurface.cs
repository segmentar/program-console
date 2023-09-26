using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static ConsoleLJ MakeConsoleLJDefaultSurface()
        {
            ConsoleLJ consoleLJResult = default;

            consoleLJResult = MakeConsoleLJDefault(ConsoleLJPolicy.ConsoleLJDebugPolicy);
            
            return consoleLJResult;
        }
    }
}
