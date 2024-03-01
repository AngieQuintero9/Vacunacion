using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMaestro : INegocioMaestro
    {
        IRepositorioMaestro repositorioMaestro = new RepositorioMaestroEF();
        public NegocioMaestro()
        {

        }
        public NegocioMaestro(IRepositorioMaestro repositorioMaestro)
        {
            this.repositorioMaestro = repositorioMaestro;
        }

        public List<Municipio> ObtenerMunicipios(int idDepartamento)
        => repositorioMaestro.ObtenerMunicipios(idDepartamento);

        public List<Departamento> ObtenerDepartamentos()
        => repositorioMaestro.ObtenerDepartamentos();

        public List<TipoDocumento> ObtenerTiposDocumento()
        => repositorioMaestro.ObtenerTiposDocumento();

        public List<RegimenAfiliacion> ObtenerRegimenAfiliacion()
        => repositorioMaestro.ObtenerRegimenAfiliacion();
    }
}