using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Chrf06IL()
        {
            if (ArchitectureOneFirst.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            var oth_STRING = Program.ArgumentArray[0];

            var safe_boolean__EQUAL_THAN = (oth_STRING.Length == 1);

            Boolean isLengthCheck, shouldReturn;

            isLengthCheck = safe_boolean__EQUAL_THAN is true;

            shouldReturn = isLengthCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            var oth_CHARACTER = oth_STRING[0];

            Specialize.SetEscapeCharacter(oth_CHARACTER, true);

            return;
        }
    }
}
