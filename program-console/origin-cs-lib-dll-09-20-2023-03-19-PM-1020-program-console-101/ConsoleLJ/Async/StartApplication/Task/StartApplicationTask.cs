using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class ConsoleLJ
    {
        public static void StartApplicationTask()
        { 
            Task task;

            task = new Task(StartApplicationAction());

            task.Start();

            return;
        }
    }
}
