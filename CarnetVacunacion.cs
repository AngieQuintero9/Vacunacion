using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacunacion
{
    public partial class CarnetVacunacion : Form
    {
        public CarnetVacunacion()
        {
            InitializeComponent();

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: 1. Recuperar los datos del formulario
                /*
                 En este paso asignamos los valores de los controles a 
                 variables locales
                 */
                var edad = rdbRecienNacido.Checked ? "Recién nacido" :
                           rdbDosMeses.Checked ? "Dos meses" :
                           rdbCuatroMeses.Checked ? "Cuatro meses" :
                           rdbSeisMeses.Checked ? "Seis meses" :
                           rdbSieteMeses.Checked ? "Siete meses" :
                           rdbDoceMeses.Checked ? "Doce meses" :
                           rdbDieciochoMeses.Checked ? "Dieciocho meses" :
                           rdbCincoAños.Checked ? "Cinco años" :
                           rdbNiñasAños.Checked ? "Niñas 9 años y mas" : "";
                var recienNacido = cboRecienNacido.SelectedItem as string;
                var dosMeses = cboDosMeses.SelectedItem as string;
                var cuatroMeses = cboCuatroMeses.SelectedItem as string;
                var seisMeses = cboSeisMeses.SelectedItem as string;
                var sieteMeses = cboSieteMeses.SelectedItem as string;
                var doceMeses = cboDoceMeses.SelectedItem as string;
                var dieciochoMeses = cboDieciochoMeses.SelectedItem as string;
                var cincoAños = cboCincoAños.SelectedItem as string;
                var niñasAños = cboNiñasAños.SelectedItem as string;
                DateTime fechaAplicacion = dtpFechaAplicacion.Value;
                string laboratorio = txtLaboratorio.Text;
                String numeroLote = txtNumeroLote.Text;
                string ipsVacunadora = txtIPSVacunadora.Text;
                DateTime fechaProxima = dtpProximaCita.Value;
                string nombreVacunador = txtNombreVacunador.Text;
                string registroVacunador = txtRegistroVacunador.Text;

                //TODO: 2. Validar los datos del formulario
                if (ValidarDatos())
                {
                    //TODO: 3. Guardar los datos del formulario en un repositorio

                    //TODO: 4. Mostrar mensaje de confirmación/negación de la operación
                    var datos = @"Edad: " + edad + "\n" + "Récien nacido: " + recienNacido + "\n" + "Dos meses: " + dosMeses + "\n" + "cuatro meses: " + cuatroMeses + "\n" + "Seis meses: " + seisMeses + "\n" + "Siete meses: " + sieteMeses + "\n" +
                        "Doce meses: " + doceMeses + "\n" + "Dieciocho meses: " + dieciochoMeses + "\n" + "cinco años: " + cincoAños + "\n" + "Niñas Años: " + niñasAños + "\n" + "Fecha aplicación: " + fechaAplicacion.ToString("yyyy/MM/dd") + "\n" + "Laboratorio: " + laboratorio + "\n" +
                                     "Número de lote: " + numeroLote + "\n" + "IPS Vacunadora: " + ipsVacunadora + "\n" + "Próxima cita: " + fechaProxima.ToString("yyyy/MM/dd") + "\n" + "Nombre vacunador: " + nombreVacunador + "\n" + "Registro vacunador: " + registroVacunador;
                    MessageBox.Show(datos, "Datos Paciente",
                        MessageBoxButtons.OK);
                }
                else
                {


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por ahora el sistema tiene dificultades. Volveremos pronto.  " +
                    "El error presentado es: " + ex.Message,
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private bool ValidarDatos()
        {
            var edad = rdbRecienNacido.Checked ? "Recién nacido" :
                           rdbDosMeses.Checked ? "Dos meses" :
                           rdbCuatroMeses.Checked ? "Cuatro meses" :
                           rdbSeisMeses.Checked ? "Seis meses" :
                           rdbSieteMeses.Checked ? "Siete meses" :
                           rdbDoceMeses.Checked ? "Doce meses" :
                           rdbDieciochoMeses.Checked ? "Dieciocho meses" :
                           rdbCincoAños.Checked ? "Cinco años" :
                           rdbNiñasAños.Checked ? "Niñas 9 años y mas" : "";
            var recienNacido = cboRecienNacido.SelectedItem as string;
            var dosMeses = cboDosMeses.SelectedItem as string;
            var cuatroMeses = cboCuatroMeses.SelectedItem as string;
            var seisMeses = cboSeisMeses.SelectedItem as string;
            var sieteMeses = cboSieteMeses.SelectedItem as string;
            var doceMeses = cboDoceMeses.SelectedItem as string;
            var dieciochoMeses = cboDieciochoMeses.SelectedItem as string;
            var cincoAños = cboCincoAños.SelectedItem as string;
            var niñasAños = cboNiñasAños.SelectedItem as string;
            DateTime fechaAplicacion = dtpFechaAplicacion.Value;
            string laboratorio = txtLaboratorio.Text;
            String numeroLote = txtNumeroLote.Text;
            string ipsVacunadora = txtIPSVacunadora.Text;
            DateTime fechaProxima = dtpProximaCita.Value;
            string nombreVacunador = txtNombreVacunador.Text;
            string registroVacunador = txtRegistroVacunador.Text;

            if (!rdbRecienNacido.Checked && !rdbDosMeses.Checked && !rdbCuatroMeses.Checked && !rdbSeisMeses.Checked
                && !rdbSieteMeses.Checked && !rdbDoceMeses.Checked && !rdbDieciochoMeses.Checked && !rdbCincoAños.Checked
                && !rdbNiñasAños.Checked)

            {
                MessageBox.Show("La edad no es válida",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(recienNacido))
            {
                MessageBox.Show("Debe seleccionar una Vacuna",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(dosMeses))
            {
                MessageBox.Show("Debe seleccionar una Vacuna",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cuatroMeses))
            {
                MessageBox.Show("Debe seleccionar una Vacuna",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(seisMeses))
            {
                MessageBox.Show("Debe seleccionar una Vacuna",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(sieteMeses))
            {
                MessageBox.Show("Debe seleccionar una Vacuna",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(doceMeses))
            {
                MessageBox.Show("Debe seleccionar una Vacuna",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(dieciochoMeses))
            {
                MessageBox.Show("Debe seleccionar una Vacuna",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cincoAños))
            {
                MessageBox.Show("Debe seleccionar una Vacuna",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(niñasAños))
            {
                MessageBox.Show("Debe seleccionar una Vacuna",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }


            if (laboratorio.Trim() == string.Empty)
            {
                MessageBox.Show("El laboratorio no debe estar vacío",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (numeroLote.Trim() == string.Empty)
            {
                MessageBox.Show("El número de lote no debe estar vacío",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (ipsVacunadora.Trim() == string.Empty)
            {
                MessageBox.Show("La IPS no debe estar vacía",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (nombreVacunador.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre del vacunador no debe estar vacío",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (registroVacunador.Trim() == string.Empty)
            {
                MessageBox.Show("El registro no debe estar vacío",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (fechaAplicacion > DateTime.Now)
            {
                MessageBox.Show("La fecha de aplicación no debe ser mayor a la fecha actual",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (fechaProxima > DateTime.MaxValue)
            {
                MessageBox.Show("La fecha de aplicación debe ser mayor a la fecha actual",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

            private void txtRegistroVacunador_Validating(object sender, CancelEventArgs e)
        {
            erpMensaje.SetError(txtRegistroVacunador, null);
            if (txtRegistroVacunador.Text.Length == 0 || txtRegistroVacunador.Text[0] != '5')
            {
                erpMensaje.SetError(txtRegistroVacunador, "El número del registro debe empezar por 5");
            }
        }
    }

}    
     
   
