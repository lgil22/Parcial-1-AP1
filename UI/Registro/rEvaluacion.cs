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

namespace Parcial1AP1.UI
{
    public partial class rEvaluacion : Form
    {
        public rEvaluacion()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            EstudiantetextBox.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
            errorProvider.Clear();
        }

        private RegistroDeEvaluacion LlenaClase()
        {
            RegistroDeEvaluacion regEv = new RegistroDeEvaluacion();
            regEv.Id = Convert.ToInt32(IDnumericUpDown.Value);
            //regEv.Id = IDtextBox.Text;
            regEv.Estudiante = EstudiantetextBox.Text;
            return regEv;

        }

        private void LlenaCampo(RegistroDeEvaluacion regEv)
           {
            IDnumericUpDown.Value = regEv.Id;
            EstudiantetextBox.Text = regEv.Estudiante;
            dateTimePicker.Value = regEv.Fecha;
        }
            private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void REvaluacion_Load(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante;
            bool paso = false;

            if (!Validate())
                return;

            estudiante = LlenaClase();
            Limpiar();

          
            if (IDnumericUpDown.Value == 0)
                paso = RegistroDeEvaluacionesBLL.Guardar(estudiante);
        
       
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    /*private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
        
        }*/
    }


