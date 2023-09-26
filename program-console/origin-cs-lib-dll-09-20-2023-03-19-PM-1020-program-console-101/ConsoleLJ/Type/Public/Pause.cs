using Core;

namespace Core
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public partial class ConsoleLJ
    {
        public void Pause()
        {
            Waiting(true);

            MessageBox.Show("paused");

            while (Data.IsWaiting is true)
            {
                Thread.Sleep(5000);

                MessageBox.Show(this.ToString());
            }

            MessageBox.Show("unpaused");

            return;
        }
    }
}
