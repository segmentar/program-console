using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Context : ApplicationContext, IExposable<Context>, IExposer
    {
        public static class ReferencePage
        {
            public static Boolean HasWindow;

            public static Boolean HasCommand;

            public static Boolean HasPrompt;

            public static Single WindowHeightRatioOneFirst;

            public static Single WindowHeightRatioTwoSecond;
        }

        public static Context Instance;

        public Context(Form form) : base(default)
        {
            ExposeReference();

            ExposeReferencePage();

            MainForm = form;

            return;
        }

        ~Context()
        {
            CleanReference();

            CleanReferencePage();

            return;
        }

        public Context ExposeReference()
        {
            Instance = this;

            return this;
        }

        public Context CleanReference()
        {
            Instance = null;

            return this;
        }

        public void ExposeReferencePage()
        {
            ReferencePage.HasWindow = (Window.Instance == default) is false;

            ReferencePage.HasCommand = (Command.Instance == default) is false;

            ReferencePage.HasPrompt = (Prompt.Instance == default) is false;

            return;
        }

        public void CleanReferencePage()
        {
            ReferencePage.HasWindow = default(Boolean);

            ReferencePage.HasCommand = default(Boolean);

            ReferencePage.HasPrompt = default(Boolean);

            return;
        }
    }
}