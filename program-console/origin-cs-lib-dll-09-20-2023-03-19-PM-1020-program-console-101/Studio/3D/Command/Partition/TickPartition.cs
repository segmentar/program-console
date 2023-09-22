using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Command
    {
        public static void TickCentral(Object sender, EventArgs e)
        {
            var boolean_safe_RETURN_should = false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || Context.ReferencePage.HasWindow is false;

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

            TickLocation(sender, e);

            TickSize(sender, e);

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Command
    {
        public static void TickLocation(Object sender, EventArgs e)
        {
            Int32 x, y;

            x = 0;

            y = 0;

            Point point;

            point = new Point(x, y);

            Instance.Location = point;

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Command
    {
        public static void TickSize(Object sender, EventArgs e)
        {
            Int32 width, height;

            width = Window.Instance.ClientRectangle.Width;

            height = (Window.Instance.ClientRectangle.Height - Prompt.Instance.Size.Height);

            Size size = new Size(width, height);

            Instance.Size = size;

            return;
        }
    }
}