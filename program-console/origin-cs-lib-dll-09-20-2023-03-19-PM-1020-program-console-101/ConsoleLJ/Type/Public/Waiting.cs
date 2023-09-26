using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public void Waiting(Boolean waiting)
        {
            if (waiting)
            {
                Data.IsWaiting = true;
            }
            else
            {
                Data.IsWaiting = false;
            }

            return;
        }
    }
}
