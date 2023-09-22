using Core;

namespace Core
{
    using System;

    public partial class Window
    {
        protected override void OnLoad(EventArgs e)
        {
            RedirectLoad(this, e);

            base.OnLoad(e);
        }
    }
}
