using Core;

namespace Core
{
    using System;

    public partial struct ConsoleLJData
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(ConsoleLJ) + ' ' + "::" + ' ' + nameof(ConsoleLJData) + ' ' + '{',
                String.Empty + '.' + "data",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsRunning) + ':' + ' ' + IsRunning,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IsWaiting) + ':' + ' ' + IsWaiting,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}'
            });
        }
    }
}
