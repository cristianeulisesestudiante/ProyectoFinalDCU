namespace ProyectoFinalDCU {
    partial class Main {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 171, 159);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nunito Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(502, 320);
            button1.Name = "button1";
            button1.Size = new Size(155, 108);
            button1.TabIndex = 0;
            button1.Text = "FILTROS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 171, 159);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nunito Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(502, 125);
            button2.Name = "button2";
            button2.Size = new Size(155, 108);
            button2.TabIndex = 1;
            button2.Text = "BUSCADOR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nunito ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(297, 34);
            label4.Name = "label4";
            label4.Size = new Size(210, 38);
            label4.TabIndex = 6;
            label4.Text = "BIENVENIDOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito ExtraBold", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 171, 159);
            label1.Location = new Point(6, 185);
            label1.Name = "label1";
            label1.Size = new Size(323, 59);
            label1.TabIndex = 3;
            label1.Text = "BIENVENIDOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 275);
            label2.Name = "label2";
            label2.Size = new Size(399, 20);
            label2.TabIndex = 4;
            label2.Text = "EL MEJOR LUGAR DONDE ENCONTRAR INFORMACION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nunito ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 237);
            label3.Name = "label3";
            label3.Size = new Size(288, 38);
            label3.TabIndex = 5;
            label3.Text = "A FIND EDUCATION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 171, 159);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-17, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 106);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_macos_minimize_30;
            pictureBox2.InitialImage = Properties.Resources.icons8_macos_minimize_30;
            pictureBox2.Location = new Point(754, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_cancelar_48;
            pictureBox1.InitialImage = Properties.Resources.icons8_cancelar_48;
            pictureBox1.Location = new Point(785, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}