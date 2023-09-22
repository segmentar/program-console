using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public String ReadLine()
        {
            String stringResult = default;

            var boolean_safe_RETURN_should = false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || ArchitectureOneFirst.HasInstance is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || Context.ReferencePage.HasPrompt is false;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is true;

            if (shouldReturnCheck is true)
            {
                return stringResult;
            }
            else
                "false".ToString();

            Data.IsWaiting = true;

            while (ArchitectureOneFirst.Instance.Data.IsWaiting is true) ;

            var result = Prompt.Instance.Text;

            Prompt.Instance.Text = String.Empty;

            stringResult = result;

            return stringResult;
        }
    }
}
