using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String[] RenderSplit(String item__PATH_RELATIVE)
        {
            String[] arrayResult = default;

            var underscore = Convert.ToChar(95);

            var split = item__PATH_RELATIVE.Split(new String[] { underscore.ToString() }, StringSplitOptions.None);

            arrayResult = split;

            return arrayResult;
        }
    }
}
