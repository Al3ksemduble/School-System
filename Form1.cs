using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escolar
{
    public partial class FrmSystem : Form
    {
        public FrmSystem()
        {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            //Declarando variáveis
            Double nota1, nota2, media;
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            
            //Calculando a média das notas
            media = (nota1 + nota2) / 2;

            //Mostrando a média do aluno
            lblMedia.Text = "A média do aluno é de: " + media;

            //Aprovado/Reprovado
            if (media >= 6.0)
            {
                lblResult.Text = "Aluno Aprovado!";
            }
            else
            {
                lblResult.Text = "Aluno Reprovado!";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpando campos
            txtNota1.Clear();
            txtNota2.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha o programa
            Close();
        }
    }
}
