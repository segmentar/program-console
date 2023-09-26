using Core;

namespace Core
{
    using System;

    using System.Diagnostics;

    public partial class ConsoleLJ
    {
        public static void Explorer(Int32 ordinal, String item_PATH)
        {
            var boolean_safe__MORE_THAN = (ordinal > 5) is true;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe__MORE_THAN is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            ProcessStartInfo processStartInfo;

            processStartInfo = new ProcessStartInfo("explorer", item_PATH);

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

                    Explorer(next, item_PATH);
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
