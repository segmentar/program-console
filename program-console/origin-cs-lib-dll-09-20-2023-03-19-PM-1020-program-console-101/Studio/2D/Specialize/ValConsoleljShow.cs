using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.Threading;

    public partial class SpecializeConsoleLJ
    {
        public static void ValConsoleLJShow(String[] array_ARGUMENT, Int32 item_TIMEOUT, Boolean answer_INTEROP_is, Boolean answer_REFLECT_is)
        {
            ArchitectureZeroTen.ArgumentArray = array_ARGUMENT;

            if (answer_INTEROP_is is true)
            {
                Interop.Lenf01IL();

                Interop.Linf02IL();

                Interop.Extf03IL();

                Interop.Reff04IL();

                Interop.Debf05IL();

                Interop.Chrf06IL();

                Interop.Escf07IL();

                Interop.Finf08IL();
            }
            else
                "false".ToString();

            ConsoleLJ consoleLJ;

            consoleLJ = ConsoleLJ.MakeConsoleLJDefaultSurface();

            SetConsoleLJInstance(consoleLJ, true);

            ConsoleLJ.ConsoleLJStartApplicationSurface(answer_REFLECT_is);

            Thread.Sleep(item_TIMEOUT);

            GetConsoleLJInstance().Running(true);

            return;
        }
    }
}
