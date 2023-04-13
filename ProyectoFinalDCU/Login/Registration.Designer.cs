namespace ProyectoFinalDCU.Login
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblRegistrate = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textIDMatricula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombre.Location = new System.Drawing.Point(148, 169);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 28);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre\r\n";
            this.txtNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNombre_MouseClick);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // lblRegistrate
            // 
            this.lblRegistrate.AutoSize = true;
            this.lblRegistrate.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistrate.ForeColor = System.Drawing.Color.White;
            this.lblRegistrate.Location = new System.Drawing.Point(148, 29);
            this.lblRegistrate.Name = "lblRegistrate";
            this.lblRegistrate.Size = new System.Drawing.Size(382, 73);
            this.lblRegistrate.TabIndex = 1;
            this.lblRegistrate.Text = "Regístrate";
            this.lblRegistrate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtApellido.Location = new System.Drawing.Point(325, 169);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(205, 28);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtApellido_MouseClick);
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // textCorreo
            // 
            this.textCorreo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textCorreo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCorreo.Location = new System.Drawing.Point(148, 213);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(382, 28);
            this.textCorreo.TabIndex = 3;
            this.textCorreo.Text = "Correo electrónico";
            this.textCorreo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textCorreo_MouseClick);
            this.textCorreo.TextChanged += new System.EventHandler(this.textCorreo_TextChanged);
            // 
            // textNumero
            // 
            this.textNumero.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textNumero.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNumero.Location = new System.Drawing.Point(148, 256);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(382, 28);
            this.textNumero.TabIndex = 4;
            this.textNumero.Text = "Número telefónico";
            this.textNumero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textNumero_MouseClick);
            this.textNumero.TextChanged += new System.EventHandler(this.textNumero_TextChanged);
            // 
            // textIDMatricula
            // 
            this.textIDMatricula.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textIDMatricula.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textIDMatricula.Location = new System.Drawing.Point(148, 129);
            this.textIDMatricula.Name = "textIDMatricula";
            this.textIDMatricula.Size = new System.Drawing.Size(382, 28);
            this.textIDMatricula.TabIndex = 5;
            this.textIDMatricula.Text = "Matrícula sin guiones";
            this.textIDMatricula.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textIDMatricula_MouseClick);
            this.textIDMatricula.TextChanged += new System.EventHandler(this.textIDMatricula_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(183)))));
            this.button1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(148, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrarte";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(660, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textIDMatricula);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblRegistrate);
            this.Controls.Add(this.txtNombre);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox txtNombre;
        private Label lblRegistrate;
        public TextBox txtApellido;
        public TextBox textCorreo;
        public TextBox textNumero;
        public TextBox textIDMatricula;
        private Button button1;
    }
}