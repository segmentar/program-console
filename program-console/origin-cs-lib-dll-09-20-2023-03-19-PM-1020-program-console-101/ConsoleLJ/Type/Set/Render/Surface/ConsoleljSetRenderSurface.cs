using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String[] ConsoleLJRenderSetSurface(Int32 index, String item__PATH_RELATIVE, params Object[] objectArray)
        {
            String[] arrayResult = default;

            var list = ConsoleLJRenderSet(item__PATH_RELATIVE, objectArray);

            var array = new String[list.Count];

            list.CopyTo(array, index);

            arrayResult = array;

            return arrayResult;
        }
    }
}
