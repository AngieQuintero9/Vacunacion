using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestroADO : IRepositorioMaestro
    {
        public List<Municipio> ObtenerMuncipio(int idDepartamento)
        {
            var municipios = new List<Municipio>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["Vacunación"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM Municipio WHERE IdDepartamento = @IdDepartamento ORDER BY Nombre";
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@IdDepartamento", idDepartamento);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        municipios.Add(new Municipio()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return municipios;
        }

        public List<Departamento> ObtenerDepartamentos()
        {
            var departamentos = new List<Departamento>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["Vacunación"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM Departamentos ORDER BY Nombre";
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        departamentos.Add(new Departamento()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return departamentos;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["Vacunación"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM TiposDocumento ORDER BY Nombre";
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tiposDocumento.Add(new TipoDocumento()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return tiposDocumento;
        }

        public List<RegimenAfiliacion> ObtenerRegimenAfiliacion()
        {
            {
                var regimenafiliacion = new List<RegimenAfiliacion>();

                var cadenaConexion = ConfigurationManager.ConnectionStrings["Vacunación"].ConnectionString;
                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "SELECT Id, Nombre FROM RegimenAfiliacion ORDER BY Nombre";
                    comando.Connection = conexion;

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            regimenafiliacion.Add(new RegimenAfiliacion()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = Convert.ToString(reader["Nombre"])
                            });
                        }
                    }
                }

                return regimenafiliacion;
            }
        }

        public List<Municipio> ObtenerMunicipio(int idDepartamento)
        {
            throw new NotImplementedException();
        }

        public List<Municipio> ObtenerMunicipios(int idDepartamento)
        {
            throw new NotImplementedException();
        }
    }
}
