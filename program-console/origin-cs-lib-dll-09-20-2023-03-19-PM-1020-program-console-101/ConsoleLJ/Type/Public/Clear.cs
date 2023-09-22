using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public void Clear()
        {
            if (Context.ReferencePage.HasCommand is false)
            {
                return;
            }
            else
                "false".ToString();

            Command.Instance.Text = String.Empty;

            return;
        }
    }
}
