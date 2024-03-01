using Negocio;
using Repositorio;

namespace Vacunacion
{
    public partial class Ingreso : Form
    {
        private const string USUARIO = "vacunacion";
        private const string CLAVE = "2023";

        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            erpMensaje.SetError(txtUsuario, null);
            erpMensaje.SetError(txtClave, null);
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpMensaje.SetError(txtUsuario, "Por favor ingresar el usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                erpMensaje.SetError(txtClave, "Por favor ingresar la contraseña");
                return;
            }


            INegocioUsuario negocio = new NegocioUsuario(new RepositorioSeguridad());
            if (negocio.ValidarUsuario(txtUsuario.Text, txtClave.Text))
            {
                var principal = new MDIPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Las credenciales de ingreso no son válidas. por favor verifique.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}