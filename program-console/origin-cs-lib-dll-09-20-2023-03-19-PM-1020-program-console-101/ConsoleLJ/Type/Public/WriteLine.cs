using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public void WriteLine(String item_LINE)
        {
            if (Context.ReferencePage.HasCommand is false)
            {
                return;
            }
            else
                "false".ToString();

            var line_feed = Convert.ToChar(10);

            var split = item_LINE.Split(new String[] { line_feed.ToString() }, StringSplitOptions.None);

            var indexer = 0;

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = indexer.Equals(split.Length) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var text = (split[indexer] + line_feed);

                Command.Instance.AppendText(text);

                indexer = indexer + 1;

                continue;

            } while (true);

            return;
        }
    }
}
