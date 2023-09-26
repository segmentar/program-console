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

        public static void Bundle(Boolean debug)
        {
            if (debug is true)
            {
                Procedure();
            }
            else
                "false".ToString();

            Manual();

            if (debug is true)
            {
                Raise();
            }
            else
                "false".ToString();

            return;
        }

        static ConsoleLJ()
        {
            return;
        }
    }
}
