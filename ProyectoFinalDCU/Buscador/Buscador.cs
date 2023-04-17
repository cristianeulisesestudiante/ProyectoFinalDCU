using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDCU.Buscador {
    public partial class Buscador : Form {
        public Buscador() {
            InitializeComponent();
        }

        private void Buscador_Load(object sender, EventArgs e) {

        }

        private void pictureBox11_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void pictureBox10_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e) {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
