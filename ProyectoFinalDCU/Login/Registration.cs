using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDCU.Login
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textIDMatricula_MouseClick(object sender, MouseEventArgs e)
        {
            textIDMatricula.Text = "";
        }

        private void textIDMatricula_TextChanged(object sender, EventArgs e)
        {
            textIDMatricula.ForeColor = Color.Black;
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.Text = "";
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            txtNombre.ForeColor = Color.Black;
        }

        private void txtApellido_MouseClick(object sender, MouseEventArgs e)
        {
            txtApellido.Text = "";
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.ForeColor = Color.Black;
        }

        private void textCorreo_TextChanged(object sender, EventArgs e)
        {
            textCorreo.ForeColor = Color.Black;
        }

        private void textCorreo_MouseClick(object sender, MouseEventArgs e)
        {
            textCorreo.Text = "";
        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {
            textNumero.ForeColor = Color.Black;
        }

        private void textNumero_MouseClick(object sender, MouseEventArgs e)
        {
            textNumero.Text = "";
        }
    }
}
