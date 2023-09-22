using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.Threading;

    public partial class ConsoleLJ
    {
        public static void Show(Boolean reflect, Int32 timeout)
        {
            ConsoleLJ consoleLJ;

            consoleLJ = MakeConsoleLJDefaultSurface(false);

            SpecializeConsoleLJ.SetConsoleLJInstance(consoleLJ, true);

            if (reflect)
            {
                StartApplicationTask();
            }
            else
            {
                StartApplicationThread();
            }

            Thread.Sleep(timeout);

            ArchitectureOneFirst.Instance.Data.IsRunning = true;

            return;
        }
    }
}
