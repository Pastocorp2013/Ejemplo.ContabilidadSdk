using SdkContabilidad.Integrator.Common;
using SdkContabilidad.Integrator.Schemas;
using SDKCONTPAQNGLib;
using System.Collections.Generic;

namespace SdkContabilidad.Integrator.Services
{
    public class ClientService
    {
        private readonly TSdkCliente _sdkEntity;

        public ClientService()
        {
            _sdkEntity = new TSdkCliente();
            _sdkEntity.setSesion(SessionService.Instance.Session);
        }
        public IEnumerable<ClienteDto> BuscarTodasPorNombre()
        {
            var cuentasList = new List<ClienteDto>();

            var sdkResult = 0;
            sdkResult = _sdkEntity.consultaPorNombre_buscaPrimero();
            if (sdkResult == SdkResult.Success)
            {
                var cuenta = MapperUtil.Cast<TSdkCliente, ClienteDto>(_sdkEntity);
                cuentasList.Add(cuenta);
            }

            do
            {
                sdkResult = _sdkEntity.consultaPorNombre_buscaSiguiente();
                if (sdkResult == SdkResult.Success)
                {
                    var cuenta = MapperUtil.Cast<TSdkCliente, ClienteDto>(_sdkEntity);
                    cuentasList.Add(cuenta);
                }
            } while (sdkResult == SdkResult.Success);

            return cuentasList;
        }

        public IEnumerable<ClienteDto> BuscarTodasPorRfc()
        {
            var cuentasList = new List<ClienteDto>();

            var sdkResult = 0;
            sdkResult = _sdkEntity.consultaPorRFC_buscaPrimero();
            if (sdkResult == SdkResult.Success)
            {
                _sdkEntity.iniciarInfo();
                var cuenta = MapperUtil.Cast<TSdkCliente, ClienteDto>(_sdkEntity);
                cuentasList.Add(cuenta);
            }

            do
            {
                sdkResult = _sdkEntity.consultaPorNombre_buscaSiguiente();
                if (sdkResult == SdkResult.Success)
                {
                    _sdkEntity.iniciarInfo();
                    var cuenta = MapperUtil.Cast<TSdkCliente, ClienteDto>(_sdkEntity);
                    cuentasList.Add(cuenta);
                }
            } while (sdkResult == SdkResult.Success);

            return cuentasList;
        }

        public ClienteDto BuscarPorCodigo(string code)
        {
            var sdkResult = 0;
            sdkResult = _sdkEntity.buscaPorCodigo(code);
            if (sdkResult == SdkResult.Success)
            {
                _sdkEntity.iniciarInfo();
                var item = MapperUtil.Cast<TSdkCliente, ClienteDto>(_sdkEntity);
                return item;
            }

            return null;
        }

        public CuentaContableDto BuscarPorCodigoAdminPaq(string code)
        {
            var sdkResult = 0;
            _sdkEntity.buscaPorCodigoAdminPAQ(code);
            if (sdkResult == SdkResult.Success)
            {
                var item = MapperUtil.Cast<TSdkCliente, CuentaContableDto>(_sdkEntity);
                return item;
            }

            return null;
        }

        public int Crear(ClienteDto item)
        {
            if (item == null)
                return 0;

            _sdkEntity.CodigoPersona = item.CodigoPersona;
            _sdkEntity.Nombre = item.Nombre;
            _sdkEntity.RFC = item.RFC;
            _sdkEntity.CURP = item.CURP;
            _sdkEntity.Telefono1 = item.Telefono1;
            _sdkEntity.Telefono2 = item.Telefono2;
            _sdkEntity.Telefono3 = item.Telefono3;
            _sdkEntity.Fax = item.Fax;
            _sdkEntity.eMail = item.eMail;
            _sdkEntity.PaginaWeb = item.PaginaWeb;
            _sdkEntity.IdDatoExtra = item.IdDatoExtra;
            _sdkEntity.PosibilidadPago = item.PosibilidadPago;
            _sdkEntity.SistOrig = item.SistOrig;
            _sdkEntity.FechaRegistro = item.FechaRegistro;
            _sdkEntity.EsCliente = item.EsCliente;
            _sdkEntity.EsProveedor = item.EsProveedor;
            _sdkEntity.EsEmpleado = item.EsEmpleado;
            _sdkEntity.EsAgente = item.EsAgente;
            _sdkEntity.EsPersona = item.EsPersona;
            _sdkEntity.EsBaja = item.EsBaja;
            _sdkEntity.GenerarPolizaAuto = item.GenerarPolizaAuto;
            _sdkEntity.CodigoCuenta = item.CodigoCuenta;
            _sdkEntity.CodigoCtaComplementaria = item.CodigoCtaComplementaria;
            _sdkEntity.CodigoPrepoliza = item.CodigoPrepoliza;
            _sdkEntity.IdSegNeg = item.IdSegNeg;
            _sdkEntity.Codigo = item.Codigo;
            _sdkEntity.CodigoClienteAdminPAQ = item.CodigoClienteAdminPAQ;
            _sdkEntity.CuentaOrigen = item.CuentaOrigen;
            _sdkEntity.BancoOrigen = item.BancoOrigen;

            var sdkResult = 0;

            sdkResult = _sdkEntity.crea();

            if (sdkResult == SdkResult.Success)
            {
                return _sdkEntity.Id;
            }

            return 0;
        }

        public bool Borrar(string code)
        {
            var sdkResult = 0;
            sdkResult = _sdkEntity.buscaPorCodigo(code);
            if (sdkResult == SdkResult.Success)
            {
                _sdkEntity.iniciarInfo();
                sdkResult = _sdkEntity.borra();

                if (sdkResult == SdkResult.Success)
                {
                    return true;
                }
            }

            return false;

            
        }
    }
}
