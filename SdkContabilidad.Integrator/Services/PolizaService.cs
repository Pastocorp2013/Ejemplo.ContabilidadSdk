using SdkContabilidad.Integrator.Common;
using SdkContabilidad.Integrator.Schemas;
using SDKCONTPAQNGLib;
using System.Collections.Generic;

namespace SdkContabilidad.Integrator.Services
{
    public class PolizaService
    {
        private readonly TSdkPoliza _sdkEntity;

        public PolizaService()
        {
            _sdkEntity = new TSdkPoliza();
            _sdkEntity.setSesion(SessionService.Instance.Session);
        }
        public IEnumerable<PolizaDto> BuscarTodosPorSistOrigenRango()
        {
            var cuentasList = new List<PolizaDto>();

            var sdkResult = 0;
            sdkResult = _sdkEntity.consultaPolizasPorSistOrigenRango_buscaPrimero();
            if (sdkResult == SdkResult.Success)
            {
                var cuenta = MapperUtil.Cast<TSdkPoliza, PolizaDto>(_sdkEntity);
                cuentasList.Add(cuenta);
            }

            do
            {
                sdkResult = _sdkEntity.consultaPolizasPorSistOrigenRango_buscaSiguiente();
                if (sdkResult == SdkResult.Success)
                {
                    var cuenta = MapperUtil.Cast<TSdkPoliza, PolizaDto>(_sdkEntity);
                    cuentasList.Add(cuenta);
                }
            } while (sdkResult == SdkResult.Success);

            return cuentasList;
        }

        public IEnumerable<PolizaDto> BuscarTodasPorEjercicioPeriodoTipoNumero()
        {
            var cuentasList = new List<PolizaDto>();

            var sdkResult = 0;
            sdkResult = _sdkEntity.consultaPorEjercicioPeriodoTipoNumero_buscaPrimero();
            if (sdkResult == SdkResult.Success)
            {
                _sdkEntity.iniciarInfo();
                var cuenta = MapperUtil.Cast<TSdkPoliza, PolizaDto>(_sdkEntity);
                cuentasList.Add(cuenta);
            }

            do
            {
                sdkResult = _sdkEntity.consultaPorEjercicioPeriodoTipoNumero_buscaSiguiente();
                if (sdkResult == SdkResult.Success)
                {
                    _sdkEntity.iniciarInfo();
                    var cuenta = MapperUtil.Cast<TSdkPoliza, PolizaDto>(_sdkEntity);
                    cuentasList.Add(cuenta);
                }
            } while (sdkResult == SdkResult.Success);

            return cuentasList;
        }

        public PolizaDto BuscaPorId(int id)
        {
            var sdkResult = 0;
            sdkResult = _sdkEntity.buscaPorId(id);
            if (sdkResult == SdkResult.Success)
            {
                _sdkEntity.iniciarInfo();
                var item = MapperUtil.Cast<TSdkPoliza, PolizaDto>(_sdkEntity);
                return item;
            }

            return null;
        }

        public PolizaDto BuscarPorLlavePrimaria(int ejercicio, int periodo, int tipoPoliza, int numero)
        {
            var sdkResult = 0;
            sdkResult = _sdkEntity.buscaPorLlavePrimaria(ejercicio, periodo, (ETIPOPOLIZA)tipoPoliza, numero);
            if (sdkResult == SdkResult.Success)
            {
                _sdkEntity.iniciarInfo();
                var item = MapperUtil.Cast<TSdkPoliza, PolizaDto>(_sdkEntity);
                return item;
            }

            return null;
        }

        public MovimientoPolizaDto BuscaMovimientoPorNumMovto(int numMovimiento)
        {
            var sdkResult = 0;
            TSdkMovimientoPoliza movimientoPoliza = new TSdkMovimientoPoliza();
            sdkResult = _sdkEntity.buscaMovimientoPorNumMovto(movimientoPoliza, numMovimiento);
            if (sdkResult == SdkResult.Success)
            {
                var item = MapperUtil.Cast<TSdkMovimientoPoliza, MovimientoPolizaDto>(movimientoPoliza);
                return item;
            }

            return null;
        }

        public int Crear(PolizaDto item)
        {
            if (item == null)
                return 0;
                        
            _sdkEntity.Fecha = item.Fecha;
            _sdkEntity.Tipo = (ETIPOPOLIZA)item.Tipo;
            _sdkEntity.Numero = item.Numero;
            _sdkEntity.Clase = (ECLASEPOLIZA)item.Clase;
            _sdkEntity.Impresa = item.Impresa;
            _sdkEntity.Concepto = item.Concepto;
            
            _sdkEntity.Diario = item.Diario;
            _sdkEntity.SistOrigen = (ESISTORIGEN)item.SistOrigen;
            _sdkEntity.Ajuste = item.Ajuste;
            _sdkEntity.CodigoDiario = item.CodigoDiario;
            _sdkEntity.Guid = item.Guid;

            var sdkResult = _sdkEntity.crea();

            if (sdkResult == SdkResult.Success)
            {
                return _sdkEntity.Id;
            }

            return 0;
        }

        public int AgregaMovimientoPoliza(MovimientoPolizaDto item)
        {
            if (item == null)
                return 0;

            TSdkMovimientoPoliza movimientoPoliza = new TSdkMovimientoPoliza
            {
                CodigoCuenta = item.CodigoCuenta,
                CodigoDiario = item.CodigoDiario,
                Concepto = item.Concepto,
                Diario = item.Diario,
                Guid = item.Guid,
                Importe = item.Importe,
                ImporteME = item.ImporteME,
                NumMovto = item.NumMovto,
                Referencia = item.Referencia,
                SegmentoNegocio = item.SegmentoNegocio,
                TipoMovto = (ETIPOIMPORTEMOVPOLIZA)item.TipoMovto
            };

            var sdkResult = _sdkEntity.agregaMovimiento(movimientoPoliza);

            if (sdkResult == SdkResult.Success)
            {
                return _sdkEntity.Id;
            }

            return 0;
        }

        public bool Borrar(int id)
        {
            var sdkResult = 0;
            sdkResult = _sdkEntity.buscaPorId(id);
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
