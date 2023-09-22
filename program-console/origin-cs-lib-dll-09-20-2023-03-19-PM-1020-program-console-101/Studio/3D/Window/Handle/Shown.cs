using Core;

namespace Core
{
    using System;

    public partial class Window
    {
        protected override void OnShown(EventArgs e)
        {
            RedirectShown(this, e);

            base.OnShown(e);
        }
    }
}
