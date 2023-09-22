using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class ConsoleLJ
    {
        public static void StartApplicationThread()
        {
            Action action;

            action = StartApplicationAction();

            Thread thread;

            thread = new Thread(new ThreadStart(action));

            thread.Start();

            return;
        }
    }
}
