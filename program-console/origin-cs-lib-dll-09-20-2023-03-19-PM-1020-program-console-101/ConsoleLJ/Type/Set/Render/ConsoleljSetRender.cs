using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ConsoleLJ
    {
        public static IList<String> ConsoleLJRenderSet(String item__PATH_RELATIVE, params Object[] objectArray)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var boolean_safe__MORE_THAN = (objectArray.Length > 0);

            Boolean hasLengthCheck, shouldSkip;

            hasLengthCheck = boolean_safe__MORE_THAN is true;

            shouldSkip = hasLengthCheck is false;

            if (shouldSkip is true)
            {
                goto skip;
            }
            else
                "false".ToString();

            item__PATH_RELATIVE = RenderSpecialName(item__PATH_RELATIVE);

            var split = RenderSplit(item__PATH_RELATIVE);

            item__PATH_RELATIVE = RenderBuildName(split, true);

            var ordinal = 1;

            foreach (Object objectItem in objectArray)
            {
                Boolean isDefaultCheck;

                isDefaultCheck = (objectItem == default) is true;

                String stringItem;

                if (isDefaultCheck)
                {
                    stringItem = ImmutableZeroTen.ErrorMessage;
                }
                else
                {
                    stringItem = objectItem.ToString();
                }

                var name = RenderFileName(split, ordinal);

                var path_FILENAME_with_extension = RenderFile(item__PATH_RELATIVE, name, stringItem, true);

                collectionResult.Add(path_FILENAME_with_extension);

                ordinal = ordinal + 1;

                continue;
            }

        skip:
            {
                return new List<String>(collectionResult);
            }
        }
    }
}
