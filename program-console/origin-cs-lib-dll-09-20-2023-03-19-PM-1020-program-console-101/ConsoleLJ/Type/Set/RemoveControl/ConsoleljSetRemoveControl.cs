using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ConsoleLJ
    {
        public static IList<Char> ConsoleLJRemoveControlSet(Object objectItem)
        {
            ICollection<Char> collectionResult = default;

            collectionResult = new Collection<Char>();

            String stringItem;

            stringItem = objectItem.ToString();

            Char[] characterArray;

            characterArray = stringItem.ToCharArray();

            foreach (Char character in characterArray)
            {
                Boolean isControlCheck;

                isControlCheck = Char.IsControl(character) is true;

                if (isControlCheck)
                {
                    var whitespace = Convert.ToChar(32);

                    collectionResult.Add(whitespace);
                }
                else
                {
                    collectionResult.Add(character);
                }

                continue;
            }

            return new List<Char>(collectionResult);
        }
    }
}
