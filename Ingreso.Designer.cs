namespace Vacunacion
{
    partial class Ingreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso));
            btnIngresar = new Button();
            btnCancelar = new Button();
            gbDatosIngreso = new GroupBox();
            lblUsuario = new Label();
            lblClave = new Label();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            erpMensaje = new ErrorProvider(components);
            ttMensaje = new ToolTip(components);
            label1 = new Label();
            gbDatosIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpMensaje).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(128, 255, 255);
            btnIngresar.Dock = DockStyle.Bottom;
            btnIngresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnIngresar.Location = new Point(0, 387);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(797, 25);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 255);
            btnCancelar.Dock = DockStyle.Bottom;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCancelar.Location = new Point(0, 359);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(797, 28);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbDatosIngreso
            // 
            gbDatosIngreso.Controls.Add(lblUsuario);
            gbDatosIngreso.Controls.Add(lblClave);
            gbDatosIngreso.Controls.Add(txtClave);
            gbDatosIngreso.Controls.Add(txtUsuario);
            gbDatosIngreso.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbDatosIngreso.Location = new Point(286, 118);
            gbDatosIngreso.Name = "gbDatosIngreso";
            gbDatosIngreso.Size = new Size(468, 182);
            gbDatosIngreso.TabIndex = 6;
            gbDatosIngreso.TabStop = false;
            gbDatosIngreso.Text = "Datos Ingreso";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblUsuario.Location = new Point(41, 63);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblClave.Location = new Point(41, 106);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(37, 15);
            lblClave.TabIndex = 6;
            lblClave.Text = "Clave";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(127, 98);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(268, 23);
            txtClave.TabIndex = 7;
            ttMensaje.SetToolTip(txtClave, "Contraseña");
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(127, 55);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(268, 23);
            txtUsuario.TabIndex = 5;
            ttMensaje.SetToolTip(txtUsuario, "Nombre de usuario");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // erpMensaje
            // 
            erpMensaje.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(77, 9);
            label1.Name = "label1";
            label1.Size = new Size(663, 60);
            label1.TabIndex = 7;
            label1.Text = "\"La vacuna es el superpoder que necesitas para vencer a los virus. \r\n¡Empodérate, vacúnate y sé invencible ante la enfermedad!\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Ingreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(797, 412);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(gbDatosIngreso);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Ingreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            Load += Ingreso_Load;
            gbDatosIngreso.ResumeLayout(false);
            gbDatosIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpMensaje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnCancelar;
        private GroupBox gbDatosIngreso;
        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private ErrorProvider erpMensaje;
        private ToolTip ttMensaje;
        private Label label1;
    }
}