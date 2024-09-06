using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGrafos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ClasseGrafo G1;

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            dgvMatriz.RowCount = (int) numVertices.Value;
            dgvMatriz.ColumnCount = (int)numVertices.Value;

            for (int i = 0; i < (int)numVertices.Value; i++)
            {
                dgvMatriz.Columns[i].Width = 50;
            }

            for (int i = 0; i < (int)numVertices.Value; i++)
                for (int j = 0; j < (int)numVertices.Value; j++) 
                {
                    dgvMatriz.Rows[i].Cells[j].Value = 0;
                }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            G1 = new ClasseGrafo((int)numVertices.Value);


            for (int i = 0; i < (int)numVertices.Value; i++)
                for (int j = 0; j < (int)numVertices.Value; j++)
                {
                    G1.MatrizGrafo1[i, j] = Convert.ToInt16(dgvMatriz.Rows[i].Cells[j].Value);
                }
            MessageBox.Show("Matriz copiada com sucesso!");
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            string resultado = G1.Multigrafo();
            lblResultado.Visible = true;
            lblResultado.Text = resultado;
        }
    }
}
