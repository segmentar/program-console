using Core;

namespace Core
{
    using System;

    using System.Threading;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ConsoleLJ
    {
        public static Action ConsoleLJStartApplicationAction()
        {
            Action actionResult = default;

            Action action;

            action = new Action(() => {

                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler((Object sender, UnhandledExceptionEventArgs e) => {

                    Render($"{ConsoleLJCode.SpecialDirectory.Core_ConsoleLJ_Domain}-{nameof(e.ExceptionObject)}Domain", e.ExceptionObject);
                });

                Application.ThreadException += new ThreadExceptionEventHandler((Object sender, ThreadExceptionEventArgs e) =>
                {
                    Render($"{ConsoleLJCode.SpecialDirectory.Core_ConsoleLJ_Application}-{e.Exception}Application", e.Exception);
                });

                Application.ApplicationExit += new EventHandler((Object sender, EventArgs e) => 
                {
                    Environment.Exit(0);
                });

                Application.EnableVisualStyles();

                Application.SetCompatibleTextRenderingDefault(false);

                Form form;

                form = new Window();

                ApplicationContext applicationContext;

                applicationContext = new Context(form);

                Application.Run(applicationContext);
            });

            actionResult = action;

            return actionResult;
        }
    }
}
