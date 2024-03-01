namespace Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public Departamento Departamento { get; set; }
        public Municipio Municipio{ get; set; }
        public Sexo Sexo { get; set; }
        public string EPS { get; set; }
        public RegimenAfiliacion RegimenAfiliacion { get; set; }
        public string LugarAtencionParto { get; set; }
        public string PesoNacer { get; set; }
        public string TallaNacer { get; set; }
        public string EdadGestacional { get; set; }

    }
}