using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.IO;

    public partial class Interop
    {
        public static void Outpf03OL(String item_DIRECTORY, String[] array_FILE)
        {
            var path_FILE_filename = Path.Combine(item_DIRECTORY, ImmutableZeroTen.OutputFileName);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ImmutableZeroTen.OutputExtension);

            if (File.Exists(path_FILE_filename_with_extension) is true)
            {
                File.Delete(path_FILE_filename_with_extension);
            }
            else
                "false".ToString();

            var line_feed = Convert.ToChar(10);

            var join = String.Join(line_feed.ToString(), array_FILE);

            File.WriteAllText(path_FILE_filename_with_extension, join);

            return;
        }
    }
}
