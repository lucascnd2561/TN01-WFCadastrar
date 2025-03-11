using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroEndereco
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            cbxEscolaridade.SelectedIndex = 0;
        }

        private void LimpaFormulario ()
        {
            txtNomeCompleto.Clear();
            mkdTelefone.Clear();
            dtpDataDeNascimento.Value = DateTime.Now;
            cbxEscolaridade.SelectedIndex = 0;
            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
            rdbNaoInformar.Checked = false;
            nudRendaMensal.Value = 0;
            chkPossuiFilhos.CheckState =
                CheckState.Indeterminate;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();
            p1.NomeCompleto = txtNomeCompleto.Text;
            p1.DddTelefone = mkdTelefone.Text;
            p1.DataNascimento = dtpDataDeNascimento.Value;
            p1.Escolaridade = cbxEscolaridade.SelectedItem!.ToString();

            if (rdbMasculino.Checked)
            {
                p1.sexo = 'M';

            }
            else if (rdbFeminino.Checked)
            {
                p1.sexo = 'F';
            }
            else if (rdbNaoInformar.Checked) 
            {
                p1.sexo = 'N';
            }
            else
            {
                MessageBox.Show("O Sexo não definido! ");
                return;
            }

            if (chkPossuiFilhos.CheckState== CheckState.Checked)
            {
                p1.PossuiFilhos = true;
            }
            else if (chkPossuiFilhos.CheckState == CheckState.Unchecked)
            {
                p1.PossuiFilhos = false;

            }
            else
            {
                MessageBox.Show("Faltou marcar se tem Filhos!");
                return;
            }

            Pessoa.ListaPessoas.Add(p1);

            MessageBox.Show("Cadastro realizado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
