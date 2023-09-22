using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class ConsoleLJ
    {
        public void Style(Color item_BACK_COLOR_command, Color item_FORE_COLOR_command, Color item_FORE_COLOR_prompt, Color item_BACK_COLOR_prompt)
        {
            var boolean_safe_RETURN_should = false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || Context.ReferencePage.HasCommand is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || Context.ReferencePage.HasPrompt is false;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            Command.Instance.BackColor = item_BACK_COLOR_command;

            Command.Instance.ForeColor = item_FORE_COLOR_command;

            Prompt.Instance.BackColor = item_BACK_COLOR_prompt;

            Prompt.Instance.ForeColor = item_FORE_COLOR_prompt;

            return;
        }
    }
}
