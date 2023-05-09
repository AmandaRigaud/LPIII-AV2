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
            button3.Hide();
            button4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
        int p=0;
        private void button2_Click(object sender, EventArgs e)
        {
            var list = ProjetoRepository.GetAll();

            var item = list.FirstOrDefault();
            p = 0;
            button4.Hide();
            button3.Show();

            label1.Text = item.Nome;
            label3.Text = item.Gerente;
            label4.Text = item.Status;
            label5.Text = item.Resumo;
            label8.Text = item.DataInicio.Value.ToShortDateString();
            label9.Text = item.DataFim.Value.ToShortDateString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var list = ProjetoRepository.GetAll();
            if (p <= list.Count-2)
            {
                p = p + 1;
                var item = list[p];

                label1.Text = item.Nome;
                label3.Text = item.Gerente;
                label4.Text = item.Status;
                label5.Text = item.Resumo;
                label8.Text = item.DataInicio.Value.ToShortDateString();
                label9.Text = item.DataFim.Value.ToShortDateString();
                button4.Show();
                if (p == list.Count()-1)
                {
                    button3.Hide();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var list = ProjetoRepository.GetAll();
            if (p > 0)
            {
                p = p - 1;
                var item = list[p];

                label1.Text = item.Nome;
                label3.Text = item.Gerente;
                label4.Text = item.Status;
                label5.Text = item.Resumo;
                label8.Text = item.DataInicio.Value.ToShortDateString();
                label9.Text = item.DataFim.Value.ToShortDateString();
                if(p == 0)
                {
                    button4.Hide();
                }
            }
            else
            {
                button4.Hide();
                button3.Show();
            }

        }
    }
}
