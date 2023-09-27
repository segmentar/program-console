using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ConsoleLJ
    {
        public static IList<String> ConsoleLJFileSet(String[] array_DIRECTORY)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (var item_DIRECTORY in array_DIRECTORY)
            {
                var array = Directory.GetFiles(item_DIRECTORY);

                foreach (var item_FILE in array)
                {
                    collectionResult.Add(item_FILE);

                    continue;
                }

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
