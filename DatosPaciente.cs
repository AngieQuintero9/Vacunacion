﻿using System;
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
    /// <summary>
    /// 
    /// </summary>
    public partial class DatosPaciente : Form
    {
        public DatosPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que permite guardar los datos de un paciente
        /// </summary>
        /// <param name="sender">Control que desencadena el evento</param>
        /// <param name="e">Datos del evento</param>
        /// <remarks></remarks>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: 1. Recuperar los datos del formulario
                /*
                 En este paso asignamos los valores de los controles a 
                 variables locales
                 */
                var primerNombre = txtPrimerNombre.Text;
                dynamic segundoNombre = txtSegundoNombre.Text;
                string primerApellido = txtPrimerApellido.Text;
                String segundoApellido = txtSegundoApellido.Text;
                var tipoDocumento = cboTiposDocumento.SelectedItem as string;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                string telefono = txtTelefono.Text;
                string direccion = txtDireccion.Text;
                var departamento = cboDepartamento.SelectedItem as string;
                var municipio = cboMunicipio.SelectedItem as string;
                var ciudad = cboCiudad.SelectedItem as string;
                var sexo = rdbFemenino.Checked ? "Femenino" :
                           rdbMasculino.Checked ? "Masculino" :
                           rdbNoBinario.Checked ? "No Binario" : "";
                var EPS = cboEPS.SelectedItem as string; ;
                var regimenAfiliacion = cboRegimenAfiliacion.SelectedItem as string;
                var departamentoNacimiento = cboDepartamentoNacimiento.SelectedItem as string;
                var municipioNacimiento = cboMunicipioNacimiento.SelectedItem as string;
                var lugarAtencionParto = cboLugarAtencionParto.SelectedItem as string;
                string pesoNacer = txtPesoNacer.Text;
                string tallaNacer = txtTallaNacer.Text;
                string edadGestacional = txtEdadGestacional.Text;

                //TODO: 2. Validar los datos del formulario
                if (ValidarDatos())
                {
                    //TODO: 3. Guardar los datos del formulario en un repositorio

                    //TODO: 4. Mostrar mensaje de confirmación/negación de la operación
                    var datos = @"Primer Nombre: " + primerNombre + "\n" + "Segundo Nombre: " + segundoNombre + "\n" + "Primer Apellido: " + primerApellido + "\n" + "Segundo Apellido: " + segundoApellido + "\n" + "Tipo Documento: " + tipoDocumento + "\n" + "Fecha Nacimiento: " + "\n" + fechaNacimiento.ToString("yyyy/MM/dd") + "Teléfono: " + telefono + "\n" + "Dirección: " + direccion + "\n" + "Departamento: " + departamento + "\n" + "Ciudad: " + ciudad + "\n" + "Sexo: " + sexo + "\n" + "EPS: " + EPS + "\n" +
                                     "Regimen Afiliacion: " + regimenAfiliacion;
                    MessageBox.Show(datos, "Datos Paciente",
                        MessageBoxButtons.OK);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor sabes te queremos. Por ahora el sistema tiene dificultades. Volveremos pronto.  " +
                    "El error presentado es: " + ex.Message,
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidarDatos()
        {
            var primerNombre = txtPrimerNombre.Text;
            dynamic segundoNombre = txtSegundoNombre.Text;
            string primerApellido = txtPrimerApellido.Text;
            String segundoApellido = txtSegundoApellido.Text;
            var tipoDocumento = cboTiposDocumento.SelectedItem as string;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            var departamento = cboDepartamento.SelectedItem as string;
            var municipio = cboMunicipio.SelectedItem as string;
            var ciudad = cboCiudad.SelectedItem as string;
            var sexo = rdbFemenino.Checked ? "Femenino" :
                       rdbMasculino.Checked ? "Masculino" :
                       rdbNoBinario.Checked ? "No Binario" : "";
            var EPS = cboEPS.SelectedItem as string;
            var regimenAfiliacion = cboRegimenAfiliacion.SelectedItem as string;
            var departamentoNacimiento = cboDepartamentoNacimiento.SelectedItem as string;
            var municipioNacimiento = cboMunicipioNacimiento.SelectedItem as string;
            var lugarAtencionParto = cboLugarAtencionParto.SelectedItem as string;
            string pesoNacer = txtPesoNacer.Text;
            string tallaNacer = txtTallaNacer.Text;
            string edadGestacional = txtEdadGestacional.Text;



            if (primerNombre.Trim() == "")
            {
                MessageBox.Show("El primer nombre no debe estar vacío",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(primerApellido.Trim()))
            {
                MessageBox.Show("El primer apellido no debe estar vacío",
                   this.Text,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(tipoDocumento))
            {
                MessageBox.Show("Debe seleccionar un tipo documento",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (fechaNacimiento > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no debe ser mayor a la fecha actual",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            if (telefono.Trim() == string.Empty)
            {
                MessageBox.Show("El teléfono no debe estar vacío",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (direccion.Trim() == string.Empty)
            {
                MessageBox.Show("La dirección no debe estar vacía",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (!rdbFemenino.Checked && !rdbMasculino.Checked && !rdbNoBinario.Checked)
            {
                MessageBox.Show("El sexo no es válido",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(regimenAfiliacion))
            {
                MessageBox.Show("Debe seleccionar un régimen de afiliación",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(EPS))
            {
                MessageBox.Show("Debe seleccionar una EPS",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txtPrimerNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper()[0];
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            erpMensaje.SetError(txtTelefono, null);
            if (txtTelefono.Text.Length == 0 || txtTelefono.Text[0] != '6')
            {
                erpMensaje.SetError(txtTelefono, "El número de celular debe empezar por 6");
            }
        }

        private void txtCelular_Validating(object sender, CancelEventArgs e)
        {
            erpMensaje.SetError(txtCelular, null);
            if (txtCelular.Text.Length == 0 || txtCelular.Text[0] != '3')
            {
                erpMensaje.SetError(txtCelular, "El número de celular debe empezar por 3");
            }
        }
    }
}
