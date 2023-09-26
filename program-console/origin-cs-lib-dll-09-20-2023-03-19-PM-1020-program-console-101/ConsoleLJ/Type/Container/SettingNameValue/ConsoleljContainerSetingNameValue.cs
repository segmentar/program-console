using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static ArrayList ConsoleLJSettingContainer__NAME_VALUE(String item__SETTING_NAME, String item__SETTING_EXTENSION, String item_NATIVE)
        {
            ArrayList listResult = default;

            var list = new ArrayList();

            var path_FILE_filename = Path.Combine(Directory.GetCurrentDirectory(), item__SETTING_NAME);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, item__SETTING_EXTENSION);

            if (File.Exists(path_FILE_filename_with_extension))
            {
                var text = File.ReadAllText(path_FILE_filename_with_extension);

                var boolean_contagious__EQUAL_OR_MORE_THAN = (text.Length >= 2);

                Boolean hasNativeCheck;

                hasNativeCheck = boolean_contagious__EQUAL_OR_MORE_THAN is true;

                String nativeString;

                if (hasNativeCheck)
                {
                    var first = text[0];

                    var second = text[1];

                    Char left, right;

                    left = first;

                    right = second;

                    Char[] characterArray;

                    characterArray = new Char[] { left, right };

                    String stringEntry;

                    stringEntry = new String(characterArray);

                    nativeString = stringEntry;
                }
                else
                {
                    nativeString = item_NATIVE;
                }

                var line_feed = Convert.ToChar(10);

                var split__TEXT = text.Split(new String[] { line_feed.ToString() }, StringSplitOptions.None);

                foreach (var item_LINE in split__TEXT)
                {
                    var split__LINE = item_LINE.Split(new String[] { nativeString }, StringSplitOptions.None);

                    Boolean shouldContniueContagious;

                    shouldContniueContagious = split__LINE.Length.Equals(2) is false;

                    if (shouldContniueContagious is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var first = split__LINE[0];

                    var second = split__LINE[1];

                    String name, value;

                    name = first;

                    value = second;

                    String formatName, formatValue;

                    formatName = name.Trim();

                    formatValue = value.Trim();

                    Boolean isNameEmptyCheck;

                    isNameEmptyCheck = formatName.Equals(String.Empty) is true;

                    shouldContniueContagious = isNameEmptyCheck is true;

                    if (shouldContniueContagious is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    Tuple<String, String> tuple;

                    tuple = new Tuple<String, String>(formatName, formatValue);

                    list.Add(tuple);

                    continue;
                }
            }
            else
            {
                StreamWriter streamWriter;

                streamWriter = File.CreateText(path_FILE_filename_with_extension);

                using (streamWriter)
                {
                    streamWriter.Write(item_NATIVE);

                    streamWriter.Flush();

                    streamWriter.Close();

                    streamWriter.Dispose();
                }
            }

            listResult = list;

            return listResult;
        }
    }
}
