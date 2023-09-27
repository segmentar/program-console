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
        public static IList<String> ConsoleLJFolderSet(String item_DIRECTORY)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (String initialDirectory in Directory.GetDirectories(item_DIRECTORY))
            {
                collectionResult.Add(initialDirectory);

                var list = new List<String>(ConsoleLJFolderSet(initialDirectory));

                foreach (String subsequentDirectory in list)
                {
                    collectionResult.Add(subsequentDirectory);

                    continue;
                }

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
