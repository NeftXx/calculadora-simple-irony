using System;
using System.Windows.Forms;
using Calculadora.Analizador;

namespace Calculadora
{
    public partial class Gui : Form
    {
        private readonly EvaluadorCalculadora evaluador;

        public Gui()
        {
            InitializeComponent();
            evaluador = new EvaluadorCalculadora();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            double resultado = evaluador.Evaluar("5 * 5 + 9 + 7 * 8");
            txtEntrada.Text = resultado.ToString();
        }
    }
}
