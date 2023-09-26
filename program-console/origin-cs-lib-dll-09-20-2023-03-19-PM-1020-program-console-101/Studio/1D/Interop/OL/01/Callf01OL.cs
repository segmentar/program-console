using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.Diagnostics;

    public partial class Interop
    {
        public static void Callf01OL(Int32 ordinal, params String[] array_ARGUMENT)
        {
            var boolean_safe_RETURN_should = false;
            
            boolean_safe_RETURN_should = boolean_safe_RETURN_should || (ordinal > 5) is true;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || ArchitectureZeroTen.HasEscapeCharacter is false;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var whitespace = Convert.ToChar(32);

            var join = String.Join(whitespace.ToString(), array_ARGUMENT);

            String fileName, arguments;

            fileName = Process.GetCurrentProcess().MainModule.FileName;

            arguments = join;

            ProcessStartInfo processStartInfo;

            processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = fileName;

            processStartInfo.Arguments = arguments;

            Process process;

            process = new Process();

            process.StartInfo = processStartInfo;

            using (process)
            {
                if (process.Start())
                {
                    goto skip;
                }
                else
                {
                    var next = (ordinal + 1);

                    Callf01OL(next, array_ARGUMENT);
                }

                skip:
                {
                    process.Close();

                    process.Dispose();
                }
            }

            return;
        }
    }
}
