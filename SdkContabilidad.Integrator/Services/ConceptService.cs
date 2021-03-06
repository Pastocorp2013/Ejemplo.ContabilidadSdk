using SdkContabilidad.Integrator.Common;
using SdkContabilidad.Integrator.Schemas;
using SDKCONTPAQNGLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdkContabilidad.Integrator.Services
{
    public class ConceptService
    {
        private readonly TSdkConcepto _sdkEntity;

        public ConceptService()
        {
            _sdkEntity = new TSdkConcepto();
            _sdkEntity.setSesion(SessionService.Instance.Session);
        }

        public IEnumerable<ConceptoDto> BuscarTodosPorNumero()
        {
            var lista = new List<ConceptoDto>();

            var sdkResult = 0;
            _sdkEntity.consultaPorNumero_buscaPrimero(ref sdkResult);
            if (sdkResult == SdkResult.Success)
            {
                var item = GetDto(_sdkEntity);
                lista.Add(item);
            }

            do
            {
                _sdkEntity.consultaPorNumero_buscaSiguiente(ref sdkResult);
                if (sdkResult == SdkResult.Success)
                {
                    var item = GetDto(_sdkEntity);
                    lista.Add(item);
                }
            } while (sdkResult == SdkResult.Success);

            return lista;
        }

        public ConceptoDto BuscarPorNumero(int nConcepto)
        {
            var sdkResult = 0;
            _sdkEntity.buscaPorNumero(nConcepto, ref sdkResult);
            if (sdkResult == SdkResult.Success)
            {
                var item = GetDto(_sdkEntity);
                return item;
            }

            return null;
        }

        public ConceptoDto BuscarPorId(int id)
        {
            var sdkResult = 0;
            _sdkEntity.buscaPorId(id, ref sdkResult);
            if (sdkResult == SdkResult.Success)
            {
                var item = GetDto(_sdkEntity);
                return item;
            }

            return null;
        }

        public int Crear(ConceptoDto item)
        {
            if (item == null)
                return 0;

            _sdkEntity.Nombre = item.Nombre;
            _sdkEntity.Numero = item.Numero;

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

        private ConceptoDto GetDto(TSdkConcepto item)
        {
            if (item == null)
                return null;

            ConceptoDto entityToReturn = new ConceptoDto
            {
                Numero = item.Numero,
                Nombre = item.Nombre,
            };

            return entityToReturn;
        }

    }
}