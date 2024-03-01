using Entidades;

namespace Repositorio
{
    public interface IRepositorioMaestro
    {
        List<Departamento> ObtenerDepartamentos();
        List<Municipio> ObtenerMunicipios(int idDepartamento);
        List<TipoDocumento> ObtenerTiposDocumento();
        List<RegimenAfiliacion> ObtenerRegimenAfiliacion();
    }
}