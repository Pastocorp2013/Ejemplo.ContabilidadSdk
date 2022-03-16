using SDKCONTPAQNGLib;
using System;

namespace SdkContabilidad.Integrator.Services
{
    public abstract class BaseService<T> where T: class
    {
        protected readonly T _sdkEntity;
        public BaseService()
        {
            _sdkEntity = (T)Activator.CreateInstance(typeof(T), null);            
        }

        public abstract void SetSesion();
    }
}
