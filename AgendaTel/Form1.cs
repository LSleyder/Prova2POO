namespace AgendaTel
{
    public partial class Form1 : Form
    {
        private Lista lista = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            int Codigo = int.Parse(tbCodigo.Text);
            string Nome = tbNome.Text;
            string Telefone = tbTel.Text;
            string Celular = tbCel.Text;
            string email = tbEmail.Text;
            string dataAniversario =  tbNiver.Text;

            Data data = new Data(dataAniversario);
            Contato codigo = new Contato(Codigo, Nome, Telefone, Celular, email, data);
           
            lista.Inserir(codigo);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            var Noh = lista.Buscar(int.Parse(tbCodigo.Text));
            try
            {
                Contato found = Noh.getData();

                tbCodigo.Text = found.getCodigo().ToString();
                tbNome.Text = found.getNome();
                tbTel.Text = found.getTelefone();
                tbCel.Text = found.getCelular();
                tbEmail.Text = found.getEmail();
                Data d = found.getNiver();
                tbNiver.Text = d.getDia().ToString() + "/" + d.getMes().ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possivel encontrar o contato", "Erro ao achar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            if(lista.Remover(nome))
            {
                tbCodigo.Text = "";
                tbNome.Text = "";
                tbTel.Text = "";
                tbCel.Text = "";
                tbEmail.Text = "";
                tbNiver.Text = "";
                MessageBox.Show("Usuario excluido", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não foi possivel encontrar o contato", "Erro ao achar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}