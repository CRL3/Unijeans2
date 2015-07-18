using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unijeans
{
    public partial class Cargando : Form
    {
        public Cargando()
        {
            InitializeComponent();
        }

        private void Cargando_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            barra_progreso.Increment(1);
            if (barra_progreso.Value == 100)
            {
                timer.Stop();
                MessageBox.Show("Termino el progreso");
            }
        }
    }
}
