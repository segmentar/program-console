using Core;

namespace Core
{
    using System;

    public partial class Prompt
    {
        public static void TickCentral(Object sender, EventArgs e)
        {
            var boolean_safe_RETURN_should = false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || Context.ReferencePage.HasWindow is false;

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

    public partial class Prompt
    {
        public static void TickLocation(Object sender, EventArgs e)
        {
            Int32 x, y;

            x = 0;

            y = (Window.Instance.ClientRectangle.Height - Instance.Size.Height);

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

    public partial class Prompt
    {
        public static void TickSize(Object sender, EventArgs e)
        {
            Int32 width;

            width = Window.Instance.ClientRectangle.Width;

            Size size;

            size = new Size(width, Instance.Size.Height);

            Instance.Size = size;

            return;
        }
    }
}
