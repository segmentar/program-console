using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static String[] ConsoleLJEscapeJoinDispenserSurface(String item_TEXT, Char item_ESCAPE)
        {
            String[] arrayResult = default;

            var list = new ArrayList(ConsoleLJEscapeJoinDispenser(item_TEXT, item_ESCAPE));

            var reflect = (String[])(list.ToArray(typeof(String)) as Array);

            var array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
