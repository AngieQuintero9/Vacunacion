using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
        public List<Municipio> ObtenerMunicipios(int idDepartamento)
        {
            var departamentos = ObtenerDepartamentos();
            var municipios = departamentos.FirstOrDefault(d => d.Id == idDepartamento).Municipio
                .OrderBy(c => c.Nombre)
                .ToList();

            return municipios;
        }

        public List<Departamento> ObtenerDepartamentos()
        {
            var departamentos = new List<Departamento>();

            departamentos.Add(new Departamento() { Id = 1, Nombre = "Amazonas", Municipio = new List<Municipio>() });
            departamentos[0].Municipio.Add(new Municipio() { Id = 1, Nombre = "Leticia" });

            departamentos.Add(new Departamento() { Id = 2, Nombre = "Antioquia", Municipio = new List<Municipio>() });
            departamentos[1].Municipio.Add(new Municipio() { Id = 2, Nombre = "Medellin" });
            
            departamentos.Add(new Departamento() { Id = 3, Nombre = "Arauca", Municipio = new List<Municipio>() });
            departamentos[2].Municipio.Add(new Municipio() { Id = 3, Nombre = "Arauca" });
   
            departamentos.Add(new Departamento() { Id = 4, Nombre = "Atlántico", Municipio = new List<Municipio>() });
            departamentos[3].Municipio.Add(new Municipio() { Id = 4, Nombre = "Barranquilla" });

            departamentos.Add(new Departamento() { Id = 5, Nombre = "Bolivar", Municipio = new List<Municipio>() });
            departamentos[4].Municipio.Add(new Municipio() { Id = 5, Nombre = "Cartagena de indias" });

            departamentos.Add(new Departamento() { Id = 6, Nombre = "Boyacá", Municipio = new List<Municipio>() });
            departamentos[5].Municipio.Add(new Municipio() { Id = 6, Nombre = "Tunja" });

            departamentos.Add(new Departamento() { Id = 7, Nombre = "Caldas", Municipio = new List<Municipio>() });
            departamentos[6].Municipio.Add(new Municipio() { Id = 7, Nombre = "Manizalez" });

            departamentos.Add(new Departamento() { Id = 8, Nombre = "Caquetá", Municipio = new List<Municipio>() });
            departamentos[7].Municipio.Add(new Municipio() { Id = 8, Nombre = "Florencia" });

            departamentos.Add(new Departamento() { Id = 9, Nombre = "Casanare", Municipio = new List<Municipio>() });
            departamentos[8].Municipio.Add(new Municipio() { Id = 9, Nombre = "Yopal" });

            departamentos.Add(new Departamento() { Id = 10, Nombre = "Cauca", Municipio = new List<Municipio>() });
            departamentos[9].Municipio.Add(new Municipio() { Id = 10, Nombre = "Popayán" });

            departamentos.Add(new Departamento() { Id = 11, Nombre = "Cesar", Municipio = new List<Municipio>() });
            departamentos[10].Municipio.Add(new Municipio() { Id = 11, Nombre = "Valledupar" });

            departamentos.Add(new Departamento() { Id = 12, Nombre = "Choco", Municipio = new List<Municipio>() });
            departamentos[11].Municipio.Add(new Municipio() { Id = 12, Nombre = "Quibdó" });

            departamentos.Add(new Departamento() { Id = 13, Nombre = "Córdoba", Municipio = new List<Municipio>() });
            departamentos[12].Municipio.Add(new Municipio() { Id = 13, Nombre = "Montería" });

            departamentos.Add(new Departamento() { Id = 14, Nombre = "Cundinamarca", Municipio = new List<Municipio>() });
            departamentos[13].Municipio.Add(new Municipio() { Id = 14, Nombre = "Bogotá" });

            departamentos.Add(new Departamento() { Id = 15, Nombre = "Guainía", Municipio = new List<Municipio>() });
            departamentos[14].Municipio.Add(new Municipio() { Id = 15, Nombre = "Inírida" });

            departamentos.Add(new Departamento() { Id = 16, Nombre = "Guaviare", Municipio = new List<Municipio>() });
            departamentos[15].Municipio.Add(new Municipio() { Id = 16, Nombre = "San José del Guaviare" });

            departamentos.Add(new Departamento() { Id = 17, Nombre = "Huila", Municipio = new List<Municipio>() });
            departamentos[16].Municipio.Add(new Municipio() { Id = 17, Nombre = "Neiva" });

            departamentos.Add(new Departamento() { Id = 18, Nombre = "Guajira", Municipio = new List<Municipio>() });
            departamentos[17].Municipio.Add(new Municipio() { Id = 18, Nombre = "Riohacha" });

            departamentos.Add(new Departamento() { Id = 19, Nombre = "Magdalena", Municipio = new List<Municipio>() });
            departamentos[18].Municipio.Add(new Municipio() { Id = 19, Nombre = "Santa Marta" });

            departamentos.Add(new Departamento() { Id = 20, Nombre = "Meta", Municipio = new List<Municipio>() });
            departamentos[19].Municipio.Add(new Municipio() { Id = 20, Nombre = "Villavicencio" });

            departamentos.Add(new Departamento() { Id = 21, Nombre = "Nariño", Municipio = new List<Municipio>() });
            departamentos[20].Municipio.Add(new Municipio() { Id = 21, Nombre = "San Juan de Pasto" });

            departamentos.Add(new Departamento() { Id = 22, Nombre = "Norte de Santande", Municipio = new List<Municipio>() });
            departamentos[21].Municipio.Add(new Municipio() { Id = 22, Nombre = "San José de Cúcuta" });

            departamentos.Add(new Departamento() { Id = 23, Nombre = "Putumayo", Municipio = new List<Municipio>() });
            departamentos[22].Municipio.Add(new Municipio() { Id = 23, Nombre = "Mocoa" });

            departamentos.Add(new Departamento() { Id = 24, Nombre = "Quindío", Municipio = new List<Municipio>() });
            departamentos[23].Municipio.Add(new Municipio() { Id = 24, Nombre = "Armenia" });

            departamentos.Add(new Departamento() { Id = 25, Nombre = "Risaralda", Municipio = new List<Municipio>() });
            departamentos[24].Municipio.Add(new Municipio() { Id = 25, Nombre = "Pereira" });

            departamentos.Add(new Departamento() { Id = 26, Nombre = "San Andrés y Providencia", Municipio = new List<Municipio>() });
            departamentos[25].Municipio.Add(new Municipio() { Id = 26, Nombre = "San Andrés" });

            departamentos.Add(new Departamento() { Id = 27, Nombre = "Santander", Municipio = new List<Municipio>() });
            departamentos[26].Municipio.Add(new Municipio() { Id = 27, Nombre = "Bucaramanga" });

            departamentos.Add(new Departamento() { Id = 28, Nombre = "Sucre", Municipio = new List<Municipio>() });
            departamentos[27].Municipio.Add(new Municipio() { Id = 28, Nombre = "Sincelejo" });

            departamentos.Add(new Departamento() { Id = 29, Nombre = "Tolima", Municipio = new List<Municipio>() });
            departamentos[28].Municipio.Add(new Municipio() { Id = 29, Nombre = "Ibagué" });

            departamentos.Add(new Departamento() { Id = 30, Nombre = "Valle del Cauca", Municipio = new List<Municipio>() });
            departamentos[29].Municipio.Add(new Municipio() { Id = 30, Nombre = "Cali" });

            departamentos.Add(new Departamento() { Id = 31, Nombre = "Vaupés", Municipio = new List<Municipio>() });
            departamentos[30].Municipio.Add(new Municipio() { Id = 31, Nombre = "Mitú" });

            departamentos.Add(new Departamento() { Id = 32, Nombre = "Vichada", Municipio = new List<Municipio>() });
            departamentos[31].Municipio.Add(new Municipio() { Id = 32, Nombre = "Puerto Carreño" });



            return departamentos;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>();

            tiposDocumento.Add(new TipoDocumento() { Id = 1, Nombre = "Cédula de Ciudadanía" });
            tiposDocumento.Add(new TipoDocumento() { Id = 2, Nombre = "Cédula de Extranjería" });
            tiposDocumento.Add(new TipoDocumento() { Id = 3, Nombre = "Tarjeta de Identidad" });

            return tiposDocumento;
        }

    
        public List<RegimenAfiliacion> ObtenerRegimenAfiliacion()
        {
            var regimenafiliaciones = new List<RegimenAfiliacion>();

            regimenafiliaciones.Add(new RegimenAfiliacion() { Id = 1, Nombre = "Subsidiado" });
            regimenafiliaciones.Add(new RegimenAfiliacion() { Id = 2, Nombre = "Contributivo" });
            regimenafiliaciones.Add(new RegimenAfiliacion() { Id = 3, Nombre = "Especial" });

            return regimenafiliaciones;
        }

        public List<Municipio> ObtenerMunicipio(int idDepartamento)
        {
            throw new NotImplementedException();
        }
    }
}
