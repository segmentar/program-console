using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static ConsoleLJ MakeConsoleLJDefault(Boolean running, Boolean debug)
        {
            ConsoleLJ consoleLJResult = default;

            var result = new ConsoleLJSequence(running, debug).Result;

            ConsoleLJPolicy.ConsoleLJArrayList.Add(result);

            consoleLJResult = result;
            
            return consoleLJResult;
        }
    }
}
