using ProyectoFinalDCU.Buscador;
using ProyectoFinalDCU.Filtros;
using ProyectoFinalDCU.Buscador;

namespace ProyectoFinalDCU {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Filter filter = new Filter();
            filter.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {
            Buscador.Buscador buscador = new Buscador.Buscador();
            buscador.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            Environment.Exit(0);

        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}