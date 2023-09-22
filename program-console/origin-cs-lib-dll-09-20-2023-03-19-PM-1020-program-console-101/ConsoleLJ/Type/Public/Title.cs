using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public void Title(String item_TITLE)
        {
            if (Context.ReferencePage.HasWindow is false)
            {
                return;
            }
            else
                "false".ToString();

            Window.Instance.Text = item_TITLE;

            return;
        }
    }
}
