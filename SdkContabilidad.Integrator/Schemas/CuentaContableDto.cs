using System;

namespace SdkContabilidad.Integrator.Schemas
{
    public class CuentaContableDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string NomIdioma { get; set; }
        public int Tipo { get; set; }
        public int EsBaja { get; set; }
        public int CtaMayor { get; set; }
        public int EsCtaEfectivo { get; set; }
        public DateTime FechaAlta { get; set; }
        public int SistOrigen { get; set; }
        public int Moneda { get; set; }
        public int DigitoAgrupador { get; set; }
        public int SegNeg { get; set; }
        public int AplicaSegNeg { get; set; }
        public string UltimoMsjError { get; set; }
        public int EsAfectable { get; set; }
        public string CodigoCuentaAcumula { get; set; }
        public int DigitoFiscal1 { get; set; }
        public int DigitoFiscal2 { get; set; }
        public string AgrupadorSAT { get; set; }
        public string NombreAgrupadorSAT { get; set; }
        public string Consume { get; set; }
    }
}