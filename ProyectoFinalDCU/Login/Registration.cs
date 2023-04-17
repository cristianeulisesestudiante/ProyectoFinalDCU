using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDCU.Login {
    public partial class Registration : Form {
        public Registration() {
            InitializeComponent();
        }

        private void textIDMatricula_MouseClick(object sender, MouseEventArgs e) {
            textIDMatricula.Text = "";
        }

        private void textIDMatricula_TextChanged(object sender, EventArgs e) {

        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e) {
            txtNombre.Text = "";
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e) {

        }

        private void txtApellido_MouseClick(object sender, MouseEventArgs e) {
            txtApellido.Text = "";
        }

        private void txtApellido_TextChanged(object sender, EventArgs e) {

        }

        private void textCorreo_TextChanged(object sender, EventArgs e) {

        }

        private void textCorreo_MouseClick(object sender, MouseEventArgs e) {
            textCorreo.Text = "";
        }

        private void textNumero_TextChanged(object sender, EventArgs e) {

        }

        private void textNumero_MouseClick(object sender, MouseEventArgs e) {
            textNumero.Text = "";
        }

        private void lblRegistrate_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label2_Click_1(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            Environment.Exit(0);

        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;


        }

        private void RegisterLink_Click(object sender, EventArgs e) {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
