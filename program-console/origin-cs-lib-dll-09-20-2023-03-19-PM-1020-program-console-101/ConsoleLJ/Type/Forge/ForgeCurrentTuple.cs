using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class ConsoleLJ
    {
        public static Tuple<String, String> ForgeCurrentTuple__FILE_DIRECTORY()
        {
            Tuple<String, String> tupleResult = default;

            var path_FILE_filename_with_extension__CURRENT = Assembly.GetEntryAssembly().Location;

            var path_DIRECTORY_full_name__CURRENT = Path.GetDirectoryName(path_FILE_filename_with_extension__CURRENT);

            String file, directory;

            file = path_FILE_filename_with_extension__CURRENT;

            directory = path_DIRECTORY_full_name__CURRENT;

            Tuple<String, String> tuple;

            tuple = new Tuple<String, String>(file, directory);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
