﻿namespace SdkContabilidad.Integrator.Schemas
{
    public class ConceptoDto
    {
        public int Id { get; }
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string UltimoMsjError { get; }
    }
}
