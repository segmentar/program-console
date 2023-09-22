using Core;

namespace Core
{
    using System;

    public partial class Window
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            RedirectHandleCreated(this, e);

            base.OnHandleCreated(e);
        }
    }
}
