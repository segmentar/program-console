using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ConsoleLJ
    {
        public static IList<String> ConsoleLJSafeStringSet(Object[] array_OBJECT)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (var item_OBJECT in array_OBJECT)
            {
                String stringItem;

                stringItem = SafeString(item_OBJECT);

                collectionResult.Add(stringItem);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
