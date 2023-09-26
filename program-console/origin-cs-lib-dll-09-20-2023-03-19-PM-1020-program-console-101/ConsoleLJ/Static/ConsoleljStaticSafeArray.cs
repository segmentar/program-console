using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String[] SafeArray(params Object[] objectArray)
        {
            String[] arrayResult = default;

            arrayResult = ConsoleLJSafeStringSetSurface(0, objectArray);

            return arrayResult;
        }
    }
}
