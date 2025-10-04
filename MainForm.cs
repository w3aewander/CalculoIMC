using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblResultado.Text = string.Empty;
            lblMsg.Text = string.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //IMC imc = new IMC();
            //imc.Peso = Convert.ToDouble(txtPeso.Text);
            //imc.Altura = Convert.ToDouble(txtAltura.Text);

            var peso = Convert.ToDouble(txtPeso.Text);
            var altura = Convert.ToDouble(txtAltura.Text);

            var  resultado = new IMC(peso,altura);

            //lblResultado.Text = $"Seu IMC é: {imc.ResultadoIMC:F2}";

            lblResultado.Text = $"Seu IMC é: {resultado.ResultadoIMC:F2}";
            lblMsg.Text = resultado.Mensagem();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
