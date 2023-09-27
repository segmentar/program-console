using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.IO;

    public partial class Interop
    {
        public static void Debf05IL()
        {
            if (ArchitectureZeroTen.ArgumentList.Contains("display-argument") is false)
            {
                return;
            }
            else
                "false".ToString();

            var comma = Convert.ToChar(44);

            var join = String.Join(comma.ToString(), ArchitectureZeroTen.ArgumentList.ToArray());

            var path_FILE_filename = Path.Combine(Directory.GetCurrentDirectory(), "DisplayArgument");

            var path_FILE_filename_wtih_extension = Path.ChangeExtension(path_FILE_filename, "txt");

            if (File.Exists(path_FILE_filename_wtih_extension) is true)
            {
                File.Delete(path_FILE_filename_wtih_extension);
            }
            else
                "false".ToString();

            File.WriteAllText(path_FILE_filename_wtih_extension, join);

            return;
        }
    }
}
