using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String RenderFileName(String[] splitArray, Int32 ordinal)
        {
            String stringResult = default;

            var eoth = (splitArray.Length - 1);

            var roth = splitArray[eoth];

            var path_NAME_file = $"{roth} {ordinal}";

            var result = path_NAME_file;

            stringResult = result;

            return stringResult;
        }
    }
}
