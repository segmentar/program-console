using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String SafeString(Object objectItem)
        {
            String stringResult = default;

            var array = ConsoleLJRemoveControlSetSurface(0, objectItem);

            String stringItem;

            stringItem = new String(array);

            stringResult = stringItem;

            return stringResult;
        }
    }
}
