 using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int IdTipoDocumento { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }  
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public int IdDepartamento { get; set; }
        public virtual Departamento Departamento { get; set; }
        public int IdMunicipio { get; set; }
        public virtual Municipio Municipio { get; set; }
        public int IdSexo { get; set; }
        public virtual Sexo Sexo { get; set; }
        public string EPS { get; set; }
        public int IdRegimenAfiliacion { get; set; }
        public virtual RegimenAfiliacion RegimenAfiliacion { get; set; }
        public string LugarAtencionParto { get; set; }
        public string PesoNacer { get; set; }
        public string TallaNacer { get; set; }
        public string EdadGestacional { get; set; }

    }
}