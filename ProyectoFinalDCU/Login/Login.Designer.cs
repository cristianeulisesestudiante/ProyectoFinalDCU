namespace ProyectoFinalDCU.Login {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblLogin = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            RegisterLink = new Label();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Verdana", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(0, 171, 159);
            lblLogin.Location = new Point(25, 214);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(353, 52);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Iniciar sesión";
            lblLogin.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 171, 169);
            textBox1.Location = new Point(12, 307);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 28);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(0, 171, 169);
            textBox2.Location = new Point(12, 373);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(382, 28);
            textBox2.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 171, 169);
            btnLogin.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(14, 407);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(382, 45);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(111, 24);
            label2.MinimumSize = new Size(200, 200);
            label2.Name = "label2";
            label2.Size = new Size(200, 200);
            label2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(12, 282);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 11;
            label1.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(12, 350);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 12;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(12, 464);
            label4.Name = "label4";
            label4.Size = new Size(220, 20);
            label4.TabIndex = 13;
            label4.Text = "No tienes una cuenta?";
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Cursor = Cursors.Hand;
            RegisterLink.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterLink.ForeColor = Color.FromArgb(0, 171, 169);
            RegisterLink.Location = new Point(238, 464);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(122, 20);
            RegisterLink.TabIndex = 14;
            RegisterLink.Text = "Creala aquí!";
            RegisterLink.Click += label5_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Cursor = Cursors.Hand;
            pictureBox10.Image = Properties.Resources.icons8_macos_minimize_30;
            pictureBox10.InitialImage = Properties.Resources.icons8_macos_minimize_30;
            pictureBox10.Location = new Point(339, 6);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(30, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 16;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Cursor = Cursors.Hand;
            pictureBox11.Image = Properties.Resources.icons8_cancelar_48;
            pictureBox11.InitialImage = Properties.Resources.icons8_cancelar_48;
            pictureBox11.Location = new Point(370, 6);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(30, 30);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 15;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(408, 524);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox11);
            Controls.Add(RegisterLink);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label RegisterLink;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
    }
}