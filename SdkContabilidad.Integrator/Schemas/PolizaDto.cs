using System;

namespace SdkContabilidad.Integrator.Schemas
{
    public class PolizaDto
    {
        public int Id { get; set; }
        public int Ejercicio { get; set; }
        public int Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public int Tipo { get; set; }
        public int Numero { get; set; }
        public int Clase { get; set; }
        public int Impresa { get; set; }
        public string Concepto { get; set; }
        public decimal Cargos { get; set; }
        public decimal Abonos { get; set; }
        public int Diario { get; set; }
        public int SistOrigen { get; set; }
        public int Ajuste { get; set; }
        public string Usuario { get; set; }
        public string UltimoMsjError { get; set; }
        public int NumeroMovtos { get; set; }
        public int NumeroMovtosControlIVA { get; set; }
        public string CodigoDiario { get; set; }
        public string Guid { get; set; }
        public string ReferenciaAsoc { get; set; }

    }
}
