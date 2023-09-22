using Core;

namespace Core.DimensionTwoSecond.ConsoleLJ
{
    using System;

    using ConsoleLJ = Core.ConsoleLJ;

    public partial class ArchitectureOneFirst
    {
        public static ConsoleLJ Instance;

        public static Boolean HasInstance;

        static ArchitectureOneFirst()
        {
            Instance = ConsoleLJDefaultArchitectureOneFirst.InstanceDefault;

            HasInstance = ConsoleLJDefaultArchitectureOneFirst.HasInstanceDefault;

            return;
        }
    }
}
