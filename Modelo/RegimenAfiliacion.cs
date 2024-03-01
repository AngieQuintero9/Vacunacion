﻿using Modelo;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    [Table("RegimenAfiliacion")]
    public class RegimenAfiliacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}