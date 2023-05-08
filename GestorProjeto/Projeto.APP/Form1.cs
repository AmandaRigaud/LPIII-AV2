using Projeto.DAL.DBContext;

namespace Projeto.APP
{
    using Projeto.BLL;
    using Projeto.MODEL;
    public partial class Form1 : Form
    {
        private readonly CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var projeto = new Projeto
            {
                Nome = nomeBox.Text,
                Gerente = gerenteBox.Text,
                DataInicio = DateTime.Parse(dateIni.Text),
                DataFim = DateTime.Parse(dateFim.Text),
                Status = status.Text,
                Resumo = resumo.Text
            };

            ProjetoRepository.Update(projeto);

            MessageBox.Show("Projeto cadastrado com sucesso!", "Cadastro de Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}