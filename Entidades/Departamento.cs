﻿namespace Entidades
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Municipio> Municipio { get; set; }


    }
}