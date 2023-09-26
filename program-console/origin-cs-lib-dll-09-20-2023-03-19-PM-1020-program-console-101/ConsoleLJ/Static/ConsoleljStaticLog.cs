using Core;

namespace Core
{
    using System;

    using System.Windows.Forms;

    public partial class ConsoleLJ
    {
        public static void Log(Boolean safe, params Object[] objectArray)
        {
            String stringItem;

            var line_feed = Convert.ToChar(10);

            if (safe)
            {
                stringItem = String.Join(line_feed.ToString(), SafeArray(objectArray));
            }
            else
            {

                stringItem = String.Join(line_feed.ToString(), objectArray);
            }

            MessageBox.Show(stringItem);

            return;
        }
    }
}
