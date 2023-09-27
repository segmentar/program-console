using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String[] ConsoleLJFileSetSurface(Int32 index, String[] array_DIRECTORY)
        {
            String[] arrayResult = default;

            var list = ConsoleLJFileSet(array_DIRECTORY);

            var array = new String[list.Count];

            list.CopyTo(array, index);

            arrayResult = array;

            return arrayResult;
        }
    }
}
