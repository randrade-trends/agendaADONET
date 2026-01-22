using agendaADONET.Classe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET { 

public partial class frmIncluirAlterarContato : Form
    {
        private Contato contato;

        public frmIncluirAlterarContato(Contato contato = null)
        {
            this.contato = contato;
        }
        frmIncluirAlterarContato()
        {
            InitializeComponent();
        }

        private void frmIncluirAlterarContato_Load(object sender, EventArgs e)
        {
            if(this.contato != null)
            {
                txbNome.Text = this.contato.Nome;
                txbEmail.Text = this.contato.email;
                txbTelofe.Text = this.contato.Telefone.ToString();

            }
            else
            {
                txbNome.Text = string.Empty;
                txbEmail.Text = string.Empty;
                txbTelefone.Text = string.Empty;
            }
            txbNome.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.contato == null)
            {
                Contato contato = new Contato
                {
                    nome = txbNome.Text,
                    Email = txbEmail.Text,
                    Telefone = Convert.ToInt32(txbTelefone.Text)

                };
                contatoDao.Inserir(contato);
            }
            else
            {
                this.contato.nome = txbNome.Text;
                this.contato.email = txbEmail.Text;
                this.contato.Telefone = ConvertToInt32(txbTelefone.Text);
                contatoDao.Atualizar(this.contato);
                   
            }
            this.Close();
    }

}

