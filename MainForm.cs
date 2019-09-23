using Parcial1AP1.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Parcial1AP1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEvaluacion ev = new rEvaluacion();
            ev.MdiParent = this;
            ev.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
