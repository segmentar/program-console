using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static ICollection ConsoleLJEscapeJoinDispenser(String item_TEXT, Char item_ESCAPE)
        {
            IList listResult = default;

            listResult = new ArrayList();

            var whitespace = Convert.ToChar(32);

            var split = item_TEXT.Split(new String[] { whitespace.ToString() }, StringSplitOptions.None);

            var enumerator = split.GetEnumerator();

            var indexer = 0;

            do
            {
                if (enumerator.MoveNext() is false)
                {
                    break;
                }
                else
                    "false".ToString();

                var current = enumerator.Current;

                String stringReflect;

                stringReflect = current as String;

                Boolean hasLengthCheck, isEscapeCheck;

                hasLengthCheck = stringReflect.Equals(String.Empty) is false;

                if (hasLengthCheck is true)
                {
                    var roth = (stringReflect.Length - 1);

                    var eoth = stringReflect[roth];

                    isEscapeCheck = eoth.Equals(ArchitectureZeroTen.EscapeCharacter);

                    if (isEscapeCheck is true)
                    {
                        goto division__PREVENT_DEFAULT;
                    }
                    else
                        "false".ToString();
                }
                else
                    "false".ToString();

                listResult.Add(stringReflect);

                indexer = indexer + 1;

                continue;

                division__PREVENT_DEFAULT:
                {
                    if (enumerator.MoveNext() is false)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var next_CURRENT = enumerator.Current;

                    var next__STRING_REFLECT = next_CURRENT as String;

                    var concat = String.Concat(stringReflect, next__STRING_REFLECT);

                    var replace = concat.Replace(item_ESCAPE, whitespace);

                    listResult.Add(replace);

                    indexer = indexer + 2;
                }

                continue;

            } while (true);

            return listResult;
        }
    }
}
