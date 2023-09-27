using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class ConsoleLJ
    {
        public static void ConsoleLJStartApplicationTask()
        { 
            Task task;

            task = new Task(ConsoleLJStartApplicationAction());

            task.Start();

            return;
        }
    }
}
