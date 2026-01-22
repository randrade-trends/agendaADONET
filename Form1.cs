using agendaADONET.Classe;

namespace agendaADONET
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmIncluirAlterarContato form = new frmIncluirAlterarContato();
            form.ShowDiaLog();
            CarregarDataGridView();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato
            {
                id = (int)dgvAgenda.CurrentRow.Cells[0].Value,
                Nome = dgvAgenda.CurrentRow.Cells[1].Value.ToString(),
                Email = dgvAgenda.CurrentRow.Cells[2].Value.ToString(),
                Telefone = (int)dgvAgenda.CurrentRow.Cells[3].Value




            };
            frmIncluirAlterarContato form = new frmIncluirAlterarContato(contato);
            form.ShowDiaLog();
            CarregarDataGridView();


        }
    }
}
