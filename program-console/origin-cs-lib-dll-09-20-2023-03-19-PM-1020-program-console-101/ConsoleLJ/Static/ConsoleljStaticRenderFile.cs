using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ConsoleLJ
    {
        public static String RenderFile(String item__PATH_RELATIVE, String item_NAME, String item_VALUE, Boolean shouldCreate)
        {
            String stringResult = default;

            var path_FILE_filename = Path.Combine(item__PATH_RELATIVE, item_NAME);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "txt");

            var boolean_CREATE_should = true;

            boolean_CREATE_should = boolean_CREATE_should && shouldCreate is true;

            boolean_CREATE_should = boolean_CREATE_should && File.Exists(path_FILE_filename_with_extension) is false;

            Boolean shouldCreateCheck;

            shouldCreateCheck = boolean_CREATE_should is true;

            if (shouldCreateCheck is true)
            {
                StreamWriter streamWriter;

                streamWriter = File.CreateText(path_FILE_filename_with_extension);

                using (streamWriter)
                {
                    streamWriter.Write(item_VALUE);

                    streamWriter.Flush();

                    streamWriter.Close();

                    streamWriter.Dispose();
                }
            }
            else
                "false".ToString();

            var result = path_FILE_filename_with_extension;

            stringResult = result;

            return stringResult;
        }
    }
}
