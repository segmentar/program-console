using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String[] ConsoleLJRenderSetSurface(String item__PATH_RELATIVE, params Object[] objectArray)
        {
            String[] arrayResult = default;

            var list = ConsoleLJRenderSet(item__PATH_RELATIVE, objectArray);

            String[] array;

            array = new String[list.Count];

            list.CopyTo(array, 0);

            arrayResult = array;

            return arrayResult;
        }
    }
}
