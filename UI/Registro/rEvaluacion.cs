using Parcial1AP1.BLL;
using Parcial1AP1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1AP1.UI.Registro
{
    public partial class rEvaluacion : Form
    {
        public rEvaluacion()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDtextBox.Text = string.Empty;
            EstudiantetextBox.Text = string.Empty;
        }

        private RegistroDeEvaluacion LlenaClase()
        {
            RegistroDeEvaluacion regEv = new RegistroDeEvaluacion();
           // regEv.Id = Convert.ToString(IDtextBox.Text);
            regEv.Id = IDtextBox.Text;
            regEv.Estudiante = EstudiantetextBox.Text;
            return regEv;

        }

        private void LlenaCampo(RegistroDeEvaluacion regEv)
           {
            IDtextBox.Text = regEv.Id;
            EstudiantetextBox.Text = regEv.Estudiante;
        }
            private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void REvaluacion_Load(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
