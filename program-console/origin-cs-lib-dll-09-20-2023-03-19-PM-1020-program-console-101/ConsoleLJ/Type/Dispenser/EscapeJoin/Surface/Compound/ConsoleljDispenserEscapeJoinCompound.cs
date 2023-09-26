using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static String ConsoleLJEscapeJoinDispenserCompound(String item_TEXT, Char item_ESCAPE)
        {
            String stringResult = default;

            var whitespace = Convert.ToChar(32);

            var join = String.Join(whitespace.ToString(), ConsoleLJEscapeJoinDispenserSurface(item_TEXT, item_ESCAPE));

            var result = join;

            stringResult = result;

            return stringResult;            
        }
    }
}
