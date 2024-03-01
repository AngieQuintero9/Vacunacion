using Entidades;

namespace Negocio
{
    public interface INegocioMaestro
    {
        List<Departamento> ObtenerDepartamentos();
        List<Municipio> ObtenerMunicipios(int idDepartamento);
        List<RegimenAfiliacion> ObtenerRegimenAfiliacion();
        List<TipoDocumento> ObtenerTiposDocumento();
    }
}