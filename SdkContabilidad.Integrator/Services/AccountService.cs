using SdkContabilidad.Integrator.Common;
using SdkContabilidad.Integrator.Schemas;
using SDKCONTPAQNGLib;
using System.Collections.Generic;

namespace SdkContabilidad.Integrator.Services
{
    public class AccountService
    {
        private readonly TSdkCuenta _sdkEntity;

        public AccountService()
        {
            _sdkEntity = new TSdkCuenta();
            _sdkEntity.setSesion(SessionService.Instance.Session);
        }
        public IEnumerable<CuentaContableDto> BuscarTodasPorCodigo()
        {
            var cuentasList = new List<CuentaContableDto>();

            var sdkResult = 0;
            _sdkEntity.consultaPorCodigo_buscaPrimero(ref sdkResult);
            if (sdkResult == SdkResult.Success)
            {
                var cuenta = MapperUtil.Cast<TSdkCuenta, CuentaContableDto>(_sdkEntity);
                cuentasList.Add(cuenta);
            }

            do
            {
                _sdkEntity.consultaPorCodigo_buscaSiguiente(ref sdkResult);
                if (sdkResult == SdkResult.Success)
                {
                    var cuenta = MapperUtil.Cast<TSdkCuenta, CuentaContableDto>(_sdkEntity);
                    cuentasList.Add(cuenta);
                }
            } while (sdkResult == SdkResult.Success);

            return cuentasList;
        }

        public IEnumerable<CuentaContableDto> BuscarTodasPorNombre()
        {
            var cuentasList = new List<CuentaContableDto>();

            var sdkResult = 0;
            _sdkEntity.consultaPorNombre_buscaPrimero(ref sdkResult);
            if (sdkResult == SdkResult.Success)
            {
                var cuenta = MapperUtil.Cast<TSdkCuenta, CuentaContableDto>(_sdkEntity);
                cuentasList.Add(cuenta);
            }

            do
            {
                _sdkEntity.consultaPorNombre_buscaSiguiente(ref sdkResult);
                if (sdkResult == SdkResult.Success)
                {
                    var cuenta = MapperUtil.Cast<TSdkCuenta, CuentaContableDto>(_sdkEntity);
                    cuentasList.Add(cuenta);
                }
            } while (sdkResult == SdkResult.Success);

            return cuentasList;
        }

        public CuentaContableDto BuscarPorNumero(string code)
        {
            var sdkResult = 0;
            sdkResult = _sdkEntity.buscaPorCodigo(code);
            if (sdkResult == SdkResult.Success)
            {
                var item = MapperUtil.Cast<TSdkCuenta, CuentaContableDto>(_sdkEntity);
                return item;
            }

            return null;
        }

        public CuentaContableDto BuscarPorId(int id)
        {
            var sdkResult = 0;
            _sdkEntity.buscaPorId(id);
            if (sdkResult == SdkResult.Success)
            {
                var item = MapperUtil.Cast<TSdkCuenta, CuentaContableDto>(_sdkEntity);
                return item;
            }

            return null;
        }
    }
}
