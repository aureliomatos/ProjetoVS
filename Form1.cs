using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno UmAluno = new Aluno();
            UmAluno.nome = "Marco Aurelio";
            UmAluno.Materia = "Matematica";
            UmAluno.Nota = 5;
            UmAluno.Professor = "Cleivaldo";

            MessageBox.Show("Aluno Aprovado com media: " + UmAluno.Nota);
           
          
            
        }
    }
}
