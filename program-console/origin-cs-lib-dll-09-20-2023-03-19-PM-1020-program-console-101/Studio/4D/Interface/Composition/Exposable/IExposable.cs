using Core;

namespace Core
{
    using System;

    public interface IExposable<T>
    { 
        T ExposeReference();

        T CleanReference();
    }
}
