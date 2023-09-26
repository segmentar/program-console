using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String[] ConsoleLJSafeStringSetSurface(Int32 index, Object[] array_OBJECT)
        {
            String[] arrayResult = default;

            var list = ConsoleLJSafeStringSet(array_OBJECT);

            var array = new String[list.Count];

            list.CopyTo(array, index);

            arrayResult = array;

            return arrayResult;
        }
    }
}
