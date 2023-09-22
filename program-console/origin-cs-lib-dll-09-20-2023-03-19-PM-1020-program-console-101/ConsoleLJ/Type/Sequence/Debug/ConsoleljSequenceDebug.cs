using Core;

namespace Core
{
    using System;
    using System.Windows.Forms;

    public partial class ConsoleLJSequence
    {
        public static void Debug(Boolean running, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(ConsoleLJ) + ' ' + "::" + ' ' + nameof(ConsoleLJSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(running) + ':' + ' ' + running,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            });

            ConsoleLJ.Render($"{ConsoleLJCode.SpecialDirectory.Core_ConsoleLJ_Debug}-{nameof(ConsoleLJ)}Debug", descriptor);

            return;
        }
    }
}
