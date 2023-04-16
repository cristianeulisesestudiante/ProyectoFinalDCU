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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblRegistrate = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textIDMatricula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(159)))));
            this.txtNombre.Location = new System.Drawing.Point(12, 309);
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
            this.lblRegistrate.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(159)))));
            this.lblRegistrate.Location = new System.Drawing.Point(23, 204);
            this.lblRegistrate.Name = "lblRegistrate";
            this.lblRegistrate.Size = new System.Drawing.Size(359, 57);
            this.lblRegistrate.TabIndex = 1;
            this.lblRegistrate.Text = "Empecemos!";
            this.lblRegistrate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegistrate.Click += new System.EventHandler(this.lblRegistrate_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtApellido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(159)))));
            this.txtApellido.Location = new System.Drawing.Point(191, 309);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(205, 28);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtApellido_MouseClick);
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // textCorreo
            // 
            this.textCorreo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textCorreo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(159)))));
            this.textCorreo.Location = new System.Drawing.Point(12, 376);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(382, 28);
            this.textCorreo.TabIndex = 3;
            this.textCorreo.Text = "Correo electrónico";
            this.textCorreo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textCorreo_MouseClick);
            this.textCorreo.TextChanged += new System.EventHandler(this.textCorreo_TextChanged);
            // 
            // textNumero
            // 
            this.textNumero.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textNumero.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(159)))));
            this.textNumero.Location = new System.Drawing.Point(12, 410);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(382, 28);
            this.textNumero.TabIndex = 4;
            this.textNumero.Text = "Número telefónico";
            this.textNumero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textNumero_MouseClick);
            this.textNumero.TextChanged += new System.EventHandler(this.textNumero_TextChanged);
            // 
            // textIDMatricula
            // 
            this.textIDMatricula.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textIDMatricula.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textIDMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(159)))));
            this.textIDMatricula.Location = new System.Drawing.Point(12, 275);
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
            this.button1.Location = new System.Drawing.Point(12, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrarte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.MaximumSize = new System.Drawing.Size(512, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(159)))));
            this.textBox1.Location = new System.Drawing.Point(12, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 28);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(111, 24);
            this.label2.MinimumSize = new System.Drawing.Size(200, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 200);
            this.label2.TabIndex = 9;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textIDMatricula);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblRegistrate);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private ImageList imageList1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}