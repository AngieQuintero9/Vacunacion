using Entidades;

namespace Repositorio
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private Modelo.Contexto contexto;
        public RepositorioPaciente()
        {
            contexto = new Modelo.Contexto();
        }

        public void IngresarPaciente(Paciente paciente)
        {
            Modelo.Paciente pacienteIngresar = new Modelo.Paciente()
            {
                PrimerNombre = paciente.PrimerNombre,
                SegundoNombre = paciente.SegundoNombre,
                PrimerApellido = paciente.PrimerApellido,
                SegundoApellido = paciente.SegundoApellido,
                NumeroDocumento = paciente.NumeroDocumento,
                IdTipoDocumento = paciente.TipoDocumento.Id,
                Direccion = paciente.Direccion,
                IdDepartamento = paciente.Departamento.Id,
                IdMunicipio = paciente.Municipio.Id,
                FechaNacimiento = paciente.FechaNacimiento,
                Telefono = paciente.Telefono,
                Celular = paciente.Celular,
                IdSexo = paciente.Sexo.Id,
                EPS = paciente.EPS,
                IdRegimenAfiliacion = paciente.RegimenAfiliacion.Id,
                LugarAtencionParto = paciente.LugarAtencionParto,
                PesoNacer = paciente.PesoNacer,
                TallaNacer = paciente.TallaNacer,
                EdadGestacional = paciente.EdadGestacional,
                
            };

            contexto.Pacientes.Add(pacienteIngresar);
            contexto.SaveChanges();
        }

        public void ActualizarPaciente(Paciente paciente)
        {
            var pacienteActual = contexto.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            pacienteActual.PrimerNombre = paciente.PrimerNombre;
            pacienteActual.SegundoNombre = paciente.SegundoNombre;
            pacienteActual.PrimerApellido = paciente.PrimerApellido;
            pacienteActual.SegundoApellido = paciente.SegundoApellido;
            pacienteActual.NumeroDocumento = paciente.NumeroDocumento;
            pacienteActual.IdTipoDocumento = paciente.TipoDocumento.Id;
            pacienteActual.Direccion = paciente.Direccion;
            pacienteActual.IdDepartamento = paciente.Departamento.Id;
            pacienteActual.IdMunicipio = paciente.Municipio.Id;
            pacienteActual.FechaNacimiento = paciente.FechaNacimiento;
            pacienteActual.Telefono = paciente.Telefono;
            pacienteActual.Celular = paciente.Celular;
            pacienteActual.IdSexo = paciente.Sexo.Id;
            pacienteActual.EPS = paciente.EPS;
            pacienteActual.IdRegimenAfiliacion = paciente.RegimenAfiliacion.Id;
            pacienteActual.LugarAtencionParto = paciente.LugarAtencionParto;
            pacienteActual.PesoNacer = paciente.PesoNacer;
            pacienteActual.TallaNacer = paciente.TallaNacer;
            pacienteActual.EdadGestacional = paciente.EdadGestacional;

            contexto.SaveChanges();
        }

        public Paciente ObtenerPaciente(string numeroDocumento)
        {
            var pacienteActual = contexto.Pacientes.FirstOrDefault(p => p.NumeroDocumento == numeroDocumento);
            if (pacienteActual != null)
                return new Entidades.Paciente()
                {
                    PrimerNombre = pacienteActual.PrimerNombre,
                    SegundoNombre = pacienteActual.SegundoNombre,
                    PrimerApellido = pacienteActual.PrimerApellido,
                    SegundoApellido = pacienteActual.SegundoApellido,
                    NumeroDocumento = pacienteActual.NumeroDocumento,
                    TipoDocumento = new TipoDocumento() { Id = pacienteActual.TipoDocumento.Id },
                    Direccion = pacienteActual.Direccion,
                    Departamento = new Departamento() {Id = pacienteActual.Departamento.Id},
                    Municipio = new Municipio()
                    {
                        Id = pacienteActual.Municipio.Id,
                        Departamento = new Departamento()
                        {
                            Id = pacienteActual.Municipio.IdDepartamento
                        }
                    },
                    FechaNacimiento = pacienteActual.FechaNacimiento,
                    Telefono = pacienteActual.Telefono,
                    Celular = pacienteActual.Celular,
                    Sexo = new Sexo() { Id = pacienteActual.Sexo.Id },
                    EPS = pacienteActual.EPS,
                    RegimenAfiliacion = new RegimenAfiliacion() { Id = pacienteActual.RegimenAfiliacion.Id },
                    LugarAtencionParto = pacienteActual.LugarAtencionParto,
                    PesoNacer = pacienteActual.PesoNacer,
                    TallaNacer = pacienteActual.TallaNacer,
                    EdadGestacional = pacienteActual.EdadGestacional
        };

            return null;
        }
    }
}