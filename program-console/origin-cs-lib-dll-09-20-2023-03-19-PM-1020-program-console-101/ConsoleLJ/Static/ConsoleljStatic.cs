using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static void Procedure()
        {
            ConsoleLJPolicy.ConsoleLJDebugPolicy = true;

            ConsoleLJPolicy.ConsoleLJInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            return;
        }

        public static void Raise()
        {
            if (ConsoleLJPolicy.ConsoleLJInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectory.Core_ConsoleLJ_Info}-{nameof(ConsoleLJ)}Info", ConsoleLJPolicy.ConsoleLJArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle()
        {
#if DEBUG
            Procedure();
#endif
            Manual();
#if DEBUG
            Raise();
#endif
            return;
        }

        static ConsoleLJ()
        {
            return;
        }
    }
}
