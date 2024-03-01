using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Municipio")]
    public class Municipio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }

        public virtual Departamento Departamento { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}