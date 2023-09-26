using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class ConsoleLJ
    {
        public void Style(ConsoleLJCode.GUIStyle styleCode, Object objectItem)
        {
            String reflectString;

            reflectString = objectItem.ToString();

            var reflect_FONT = default(Font);

            var reflect_COLOR = default(Color);

            try
            {
                reflect_FONT = (Font)objectItem;

            } catch (Exception exception)
            {
                exception.ToString();
            }

            try
            {
                reflect_COLOR = Color.FromName(reflectString);
            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            switch (styleCode)
            {
                case ConsoleLJCode.GUIStyle.CommandBackColor:
                    Command.Instance.BackColor = reflect_COLOR;
                    break;

                case ConsoleLJCode.GUIStyle.CommandForeColor:
                    Command.Instance.ForeColor = reflect_COLOR;
                    break;

                case ConsoleLJCode.GUIStyle.CommandFont:
                    Command.Instance.Font = reflect_FONT;
                    break;

                case ConsoleLJCode.GUIStyle.PromptBackColor:
                    Prompt.Instance.BackColor = reflect_COLOR;
                    break;

                case ConsoleLJCode.GUIStyle.PromptForeColor:
                    Prompt.Instance.ForeColor = reflect_COLOR;
                    break;

                case ConsoleLJCode.GUIStyle.PromptFont:
                    Prompt.Instance.Font = reflect_FONT;
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
