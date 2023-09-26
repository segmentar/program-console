using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Debf05IL()
        {
            if (ArchitectureOneFirst.ArgumentList.Contains("display-argument") is false)
            {
                return;
            }
            else
                "false".ToString();

            var comma = Convert.ToChar(44);

            var join = String.Join(comma.ToString(), ArchitectureOneFirst.ArgumentList.ToArray());

            ConsoleLJ.Render($"{ConsoleLJCode.SpecialDirectory.Core_Interop}-{nameof(Debf05IL)}Interop", join);

            return;
        }
    }
}
