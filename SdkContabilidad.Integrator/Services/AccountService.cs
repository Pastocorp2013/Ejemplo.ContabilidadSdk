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

        public CuentaContableDto BuscarPorCodigo(string code)
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

        public int Crear(CuentaContableDto item)
        {
            if (item == null)
                return 0;

            _sdkEntity.Nombre = item.Nombre;
            _sdkEntity.Codigo = item.Codigo;
            _sdkEntity.NomIdioma = item.NomIdioma;
            _sdkEntity.Tipo = (ECUENTATIPO)item.Tipo;
            _sdkEntity.EsBaja = item.EsBaja;
            _sdkEntity.CtaMayor = (ECUENTADEMAYOR)item.CtaMayor;
            _sdkEntity.setEsCtaEfectivo = item.EsCtaEfectivo;
            _sdkEntity.FechaAlta = item.FechaAlta;
            _sdkEntity.SistOrigen = (ESISTORIGEN) item.SistOrigen;
            _sdkEntity.Moneda = item.Moneda;
            _sdkEntity.DigitoAgrupador = item.DigitoAgrupador;
            _sdkEntity.AplicaSegNeg = item.AplicaSegNeg;
            _sdkEntity.CodigoCuentaAcumula = item.CodigoCuentaAcumula;
            _sdkEntity.DigitoFiscal1 = item.DigitoFiscal1;
            _sdkEntity.DigitoFiscal2 = item.DigitoFiscal2;
            _sdkEntity.AgrupadorSAT = item.AgrupadorSAT;
            _sdkEntity.Consume = item.Consume;

            var sdkResult = 0;

            _sdkEntity.crea(ref sdkResult);

            if (sdkResult == SdkResult.Success)
            {
                return _sdkEntity.Id;
            }

            return 0;
        }

        public bool Borrar(int id)
        {
            _sdkEntity.setId = id;

            var sdkResult = 0;

            _sdkEntity.borra(ref sdkResult);

            if (sdkResult == SdkResult.Success)
            {
                return true;
            }

            return false;
        }
    }
}
