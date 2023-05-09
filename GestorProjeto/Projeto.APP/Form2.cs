using Projeto.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.APP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var texto = "";

            var list = ProjetoRepository.GetAll();
            var linha = "Nome do Projeto | Gerente | Resumo | STATUS | Data inicio | Data Fim\n\n ";

            foreach (var item in list)
            {
                texto = "\n" + item.Nome + " | " + item.Gerente + " | " + item.Resumo + " | " + item.Status + " | " + item.DataInicio.Value.ToShortDateString() + " | " + item.DataFim.Value.ToShortDateString() + "\n";
                linha = linha + texto;
                label1.Text = linha;
            }
        }

        bool isClicked = false;
        private void label1_Click(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                var texto = "";

                var list = ProjetoRepository.GetAll();
                var linha = "Nome do Projeto | Gerente | Resumo | STATUS | Data inicio | Data Fim\n\n";

                foreach (var item in list)
                {
                    texto = "\n" + item.Nome + " | " + item.Gerente + " | " + item.Resumo + " | " + item.Status + " | " + item.DataInicio.Value.ToShortDateString() + " | " + item.DataFim.Value.ToShortDateString() + "\n";
                    linha = linha + texto;
                    label1.Text = linha;
                }
            }
            isClicked = true;

        }
    }
}
