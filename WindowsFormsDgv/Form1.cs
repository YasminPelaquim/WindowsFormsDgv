using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDgv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            // adiciona o conteúdo das caixas de texto nas colunas correspondentes
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);
            // limpa as caixas de texto
            txtNome.Clear();
            txtCurso.Clear();
            // exibe uma mensagem ao usuário de inclusão com sucesso
            MessageBox.Show("Aluno Incluido com sucesso", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // exibe ma label o contador de linhas do GridView atualizado após a inserção
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // verifica a existência de linhas no Grid
            if (dgvAlunos.Rows.Count > 0)
            {
                // remove a linha selecionada do grid
                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
                // exibe uma mensagem ao usuário de exclusão com sucesso!
                MessageBox.Show("Aluno Excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // exibe na label o contador de linhas do GridView atualizado após a remoção
                lblTotal.Text = dgvAlunos.RowCount.ToString();
            }
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica a existência de linhas no Grid
            if (dgvAlunos.RowCount > 0)
            {
                // move o conteúdo da primeira célula da linha selecionada para a caixa de texto
                txtAlteracao.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
                // pode usar o indice ou o nome da coluna(["nome"])
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlteracao.Text != "")
            {
                // move o novo valor da caixa de text Alteração para a célula selecionada
                dgvAlunos.CurrentRow.Cells[0].Value = txtAlteracao.Text;
                // exibe a mensagem de alteração com sucesso
                MessageBox.Show("Aluno Alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            // zera as linhas do grid, removendo as existentes
            dgvAlunos.RowCount = 0;
            // exibe na label o contador de linhas do GridView após ser zerado
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // finaliza a aplicação
            Application.Exit();
        }
    }
}
