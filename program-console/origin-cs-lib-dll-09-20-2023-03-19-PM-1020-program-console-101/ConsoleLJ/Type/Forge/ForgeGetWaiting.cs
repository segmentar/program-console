using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class ConsoleLJ
    {
        public Boolean GetWaiting(Int32 timeout)
        {
            Boolean booleanResult = default;

            Thread.Sleep(timeout);

            Boolean boolean;

            if (Data.IsWaiting)
            {
                boolean = true;
            }
            else
            {
                boolean = false;
            }

            booleanResult = boolean;

            return booleanResult;
        }
    }
}
