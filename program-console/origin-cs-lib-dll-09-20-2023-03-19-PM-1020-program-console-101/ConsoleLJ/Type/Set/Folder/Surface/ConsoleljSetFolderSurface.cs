using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String[] ConsoleLJFolderSetSurface(Int32 index, String item_DIRECTORY)
        {
            String[] arrayResult = default;

            var list = ConsoleLJFolderSet(item_DIRECTORY);

            var array = new String[list.Count];

            list.CopyTo(array, index);

            arrayResult = array;

            return arrayResult;
        }
    }
}
