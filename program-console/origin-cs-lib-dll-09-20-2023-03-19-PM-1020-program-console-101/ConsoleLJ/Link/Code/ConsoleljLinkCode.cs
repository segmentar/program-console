using Core;

namespace Core
{
    public partial class ConsoleLJCode
    {
        public enum SpecialDirectory
        {
            Unset,
            Core,
            Core_Debug,
            Core_Info,
            Core_Interop,
            Core_ConsoleLJ_Debug,
            Core_ConsoleLJ_Info,
            Core_ConsoleLJ_Domain,
            Core_ConsoleLJ_Application,
        }

        public enum GUIStyle
        {
            CommandBackColor,
            CommandForeColor,
            CommandFont,
            PromptBackColor,
            PromptForeColor,
            PromptFont,
            Unset
        }
    }
}