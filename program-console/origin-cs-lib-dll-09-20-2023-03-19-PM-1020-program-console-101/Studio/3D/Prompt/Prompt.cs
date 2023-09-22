using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Prompt : TextBox, IExposable<Prompt>, ICentralOrder, IStyleOrder, ITimeOrder
    {
        public static Prompt Instance;

        public Prompt()
        {
            ExposeReference();

            CentralOrder();

            return;
        }

        ~Prompt()
        {
            CleanReference();

            return;
        }

        public Prompt ExposeReference()
        {
            Instance = this;

            return this;
        }

        public Prompt CleanReference()
        {
            Instance = null;

            return this;
        }

        public void CentralOrder()
        {
            StyleOrder();

            TimeOrder();

            return;
        }

        public void StyleOrder()
        {
            BackColor = ImmutableThreeThird.BackColor;

            ForeColor = ImmutableThreeThird.ForeColor;

            Font = new Font(ImmutableThreeThird.FontFamily, ImmutableThreeThird.FontSize, ImmutableThreeThird.FontStyle);

            return;
        }

        public void TimeOrder()
        {
            Timer timer;

            timer = new Timer();

            timer.Tick += TickCentral;

            timer.Start();

            return;
        }
    }
}
