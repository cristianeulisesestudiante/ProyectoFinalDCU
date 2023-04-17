using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDCU.Filtros {
    public partial class Filter : Form {
        bool sidebarExpand = true;
        bool homeCollapse = true;
        public Filter() {
            InitializeComponent();
        }

        private void slidebarTimer_Tick(object sender, EventArgs e) {
            if (sidebarExpand) {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width) {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            } else {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width) {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e) {
            sidebarTimer.Start();
        }

        private void generalTimer_Tick(object sender, EventArgs e) {
            if (homeCollapse) {
                homeContainer.Height += 10;
                if (homeContainer.Height == homeContainer.MaximumSize.Height) {
                    homeCollapse = false;
                    generalTimer.Stop();

                }
            } else {
                homeContainer.Height -= 10;
                if (homeContainer.Height == homeContainer.MinimumSize.Height) {
                    homeCollapse = true;
                    generalTimer.Stop();
                }
            }
        }

        private void btnHomee_Click(object sender, EventArgs e) {
            generalTimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e) {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
