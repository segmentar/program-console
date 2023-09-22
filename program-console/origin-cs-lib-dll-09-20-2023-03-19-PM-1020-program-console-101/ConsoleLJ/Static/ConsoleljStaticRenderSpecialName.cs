using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String RenderSpecialName(String item__PATH_RELATIVE)
        {
            String stringResult = default;

            var dash = Convert.ToChar(45);

            var underscore = Convert.ToChar(95);

            var replace = item__PATH_RELATIVE.Replace(dash.ToString(), underscore.ToString());

            var result = replace;

            stringResult = result;

            return stringResult;
        }
    }
}
