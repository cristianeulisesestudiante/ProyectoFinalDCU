namespace ProyectoFinalDCU.Login {
    partial class Registration {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            txtNombre = new TextBox();
            lblRegistrate = new Label();
            txtApellido = new TextBox();
            textCorreo = new TextBox();
            textNumero = new TextBox();
            textIDMatricula = new TextBox();
            button1 = new Button();
            imageList1 = new ImageList(components);
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            RegisterLink = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.MenuBar;
            txtNombre.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(0, 171, 159);
            txtNombre.Location = new Point(12, 309);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 28);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre\r\n";
            txtNombre.MouseClick += txtNombre_MouseClick;
            txtNombre.TextChanged += txtNombre_TextChanged_1;
            // 
            // lblRegistrate
            // 
            lblRegistrate.AutoSize = true;
            lblRegistrate.Font = new Font("Verdana", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrate.ForeColor = Color.FromArgb(0, 171, 159);
            lblRegistrate.Location = new Point(23, 204);
            lblRegistrate.Name = "lblRegistrate";
            lblRegistrate.Size = new Size(359, 57);
            lblRegistrate.TabIndex = 1;
            lblRegistrate.Text = "Empecemos!";
            lblRegistrate.TextAlign = ContentAlignment.TopCenter;
            lblRegistrate.Click += lblRegistrate_Click;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.MenuBar;
            txtApellido.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.FromArgb(0, 171, 159);
            txtApellido.Location = new Point(191, 309);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(205, 28);
            txtApellido.TabIndex = 2;
            txtApellido.Text = "Apellido";
            txtApellido.MouseClick += txtApellido_MouseClick;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // textCorreo
            // 
            textCorreo.BackColor = SystemColors.MenuBar;
            textCorreo.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textCorreo.ForeColor = Color.FromArgb(0, 171, 159);
            textCorreo.Location = new Point(12, 376);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(382, 28);
            textCorreo.TabIndex = 3;
            textCorreo.Text = "Correo electrónico";
            textCorreo.MouseClick += textCorreo_MouseClick;
            textCorreo.TextChanged += textCorreo_TextChanged;
            // 
            // textNumero
            // 
            textNumero.BackColor = SystemColors.MenuBar;
            textNumero.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textNumero.ForeColor = Color.FromArgb(0, 171, 159);
            textNumero.Location = new Point(12, 410);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(382, 28);
            textNumero.TabIndex = 4;
            textNumero.Text = "Número telefónico";
            textNumero.MouseClick += textNumero_MouseClick;
            textNumero.TextChanged += textNumero_TextChanged;
            // 
            // textIDMatricula
            // 
            textIDMatricula.BackColor = SystemColors.MenuBar;
            textIDMatricula.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textIDMatricula.ForeColor = Color.FromArgb(0, 171, 159);
            textIDMatricula.Location = new Point(12, 275);
            textIDMatricula.Name = "textIDMatricula";
            textIDMatricula.Size = new Size(382, 28);
            textIDMatricula.TabIndex = 5;
            textIDMatricula.Text = "Matrícula sin guiones";
            textIDMatricula.MouseClick += textIDMatricula_MouseClick;
            textIDMatricula.TextChanged += textIDMatricula_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 202, 183);
            button1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 444);
            button1.Name = "button1";
            button1.Size = new Size(384, 50);
            button1.TabIndex = 6;
            button1.Text = "Registrarte";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "edit.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(12, 24);
            label1.MaximumSize = new Size(512, 512);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 171, 159);
            textBox1.Location = new Point(12, 343);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 28);
            textBox1.TabIndex = 8;
            textBox1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(111, 24);
            label2.MinimumSize = new Size(200, 200);
            label2.Name = "label2";
            label2.Size = new Size(200, 200);
            label2.TabIndex = 9;
            label2.Click += label2_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_macos_minimize_30;
            pictureBox2.InitialImage = Properties.Resources.icons8_macos_minimize_30;
            pictureBox2.Location = new Point(340, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_cancelar_48;
            pictureBox1.InitialImage = Properties.Resources.icons8_cancelar_48;
            pictureBox1.Location = new Point(371, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Cursor = Cursors.Hand;
            RegisterLink.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterLink.ForeColor = Color.FromArgb(0, 171, 169);
            RegisterLink.Location = new Point(202, 511);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(161, 18);
            RegisterLink.TabIndex = 16;
            RegisterLink.Text = "Iniciar sesión aquí!";
            RegisterLink.Click += RegisterLink_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(23, 511);
            label4.Name = "label4";
            label4.Size = new Size(176, 18);
            label4.TabIndex = 15;
            label4.Text = "Ya tengo una cuenta";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(408, 560);
            Controls.Add(RegisterLink);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textIDMatricula);
            Controls.Add(textNumero);
            Controls.Add(textCorreo);
            Controls.Add(txtApellido);
            Controls.Add(lblRegistrate);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label RegisterLink;
        private Label label4;
    }
}