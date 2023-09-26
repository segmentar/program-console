using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static Char[] ConsoleLJRemoveControlSetSurface(Int32 index, Object objectItem)
        {
            Char[] arrayResult = default;

            var list = ConsoleLJRemoveControlSet(objectItem);

            var array = new Char[list.Count];

            list.CopyTo(array, index);

            arrayResult = array;

            return arrayResult;
        }
    }
}
