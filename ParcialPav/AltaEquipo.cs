using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialPav
{
    public partial class AltaEquipo : Form
    {
        public AltaEquipo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AltaEquipo_Load(object sender, EventArgs e)
        {
            cargarFecha();
        }
        private void cargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
