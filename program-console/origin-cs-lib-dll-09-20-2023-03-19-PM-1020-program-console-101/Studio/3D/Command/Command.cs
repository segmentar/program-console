using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Command : RichTextBox, IExposable<Command>, ICentralOrder, IStyleOrder, IEventOrder, ITimeOrder
    {
        public static Command Instance;

        public Command()
        {
            ExposeReference();

            CentralOrder();

            return;
        }

        ~Command()
        {
            CleanReference();

            return;
        }

        public Command ExposeReference()
        {
            Instance = this;

            return this;
        }

        public Command CleanReference()
        {
            Instance = null;

            return this;
        }

        public void CentralOrder()
        {
            StyleOrder();

            EventOrder();

            TimeOrder();

            return;
        }

        public void StyleOrder()
        {
            Text = ImmutableTwoSecond.Text;

            Multiline = ImmutableTwoSecond.Multiline;

            AcceptsTab = ImmutableTwoSecond.AcceptTab;

            ReadOnly = ImmutableTwoSecond.ReadOnly;

            WordWrap = ImmutableTwoSecond.WordWrap;

            ScrollBars = ImmutableTwoSecond.ScrollBars;

            BackColor = ImmutableTwoSecond.BackColor;

            ForeColor = ImmutableTwoSecond.ForeColor;

            Font = new Font(ImmutableTwoSecond.FontFamily, ImmutableTwoSecond.FontSize, ImmutableTwoSecond.FontStyle);

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

        public void EventOrder()
        {
            KeyDown += Window.RedirectKeyDown;

            return;
        }
    }
}
