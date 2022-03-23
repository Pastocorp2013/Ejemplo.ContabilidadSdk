namespace SdkContabilidad.Integrator.Schemas
{
    public class MovimientoPolizaDto
    {        
        public int Id { get; set; }
        public int IdPoliza { get; set; }
        public int NumMovto { get; set; }
        public string CodigoCuenta { get; set; }
        public int TipoMovto { get; set; }
        public decimal Importe { get; set; }
        public decimal ImporteME { get; set; }
        public string Referencia { get; set; }
        public string Concepto { get; set; }
        public int Diario { get; set; }
        public string SegmentoNegocio { get; set; }
        public int IdCuenta { get; set; }
        public int IdDiario { get; set; }
        public int IdSegNeg { get; set; }
        public string CodigoDiario { get; set; }
        public string Guid { get; set; }
    }
}
