using System;

namespace SdkContabilidad.Integrator.Schemas
{
    public class ClienteDto
    {
        public string CodigoPersona { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Fax { get; set; }
        public string eMail { get; set; }
        public string PaginaWeb { get; set; }
        public int IdDatoExtra { get; set; }
        public int PosibilidadPago { get; set; }
        public int SistOrig { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int EsCliente { get; set; }
        public int EsProveedor { get; set; }
        public int EsEmpleado { get; set; }
        public int EsAgente { get; set; }
        public int EsPersona { get; set; }
        public int EsBaja { get; set; }
        public int GenerarPolizaAuto { get; set; }
        public string CodigoCuenta { get; set; }
        public string CodigoCtaComplementaria { get; set; }
        public string CodigoPrepoliza { get; set; }
        public int IdSegNeg { get; set; }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string CodigoClienteAdminPAQ { get; set; }
        public string CuentaOrigen { get; set; }
        public string BancoOrigen { get; set; }
    }
}
