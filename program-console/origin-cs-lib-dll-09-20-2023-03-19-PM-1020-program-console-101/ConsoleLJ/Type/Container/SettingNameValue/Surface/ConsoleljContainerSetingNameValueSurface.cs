using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static T[] ConsoleLJSettingContainerSurface__NAME_VALUE<T>(String item__SETTING_NAME, String item__SETTING_EXTENSION, String item_NATIVE)
        {
            T[] arrayResult = default;

            var list = ConsoleLJSettingContainer__NAME_VALUE(item__SETTING_NAME, item__SETTING_EXTENSION, item_NATIVE);

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            T[] array;

            array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
