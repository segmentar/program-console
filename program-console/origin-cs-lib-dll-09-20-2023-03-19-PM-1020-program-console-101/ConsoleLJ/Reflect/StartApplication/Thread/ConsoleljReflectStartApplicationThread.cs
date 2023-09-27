using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class ConsoleLJ
    {
        public static void ConsoleLJStartApplicationThread()
        {
            Action action;

            action = ConsoleLJStartApplicationAction();

            Thread thread;

            thread = new Thread(new ThreadStart(action));

            thread.Start();

            return;
        }
    }
}
