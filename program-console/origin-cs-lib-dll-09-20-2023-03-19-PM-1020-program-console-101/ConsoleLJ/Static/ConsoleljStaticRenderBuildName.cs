using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ConsoleLJ
    {
        public static String RenderBuildName(String[] splitArray, Boolean shouldCreate)
        {
            String stringResult = default;

            var path_DIRECTORY_full_name = String.Empty;

            foreach (String stringItem in splitArray)
            {
                path_DIRECTORY_full_name = Path.Combine(path_DIRECTORY_full_name, stringItem);

                continue;
            }

            var boolean_CREATE_should = true;

            boolean_CREATE_should = boolean_CREATE_should && shouldCreate is true;

            boolean_CREATE_should = boolean_CREATE_should && Directory.Exists(path_DIRECTORY_full_name) is false;

            Boolean shouldCreateCheck;

            shouldCreateCheck = boolean_CREATE_should is true;

            if (shouldCreateCheck is true)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var result = path_DIRECTORY_full_name;

            stringResult = result;

            return stringResult;
        }
    }
}
