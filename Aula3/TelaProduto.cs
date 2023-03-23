using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();

        private void CarregaCategoria() // private void label3_Click(object sender, EventArgs e)
        {
            cbxCategoria.DataSource = null;
            cbxCategoria.DataSource = con.Retorna(
            "select * from tb_categoria"
            );
            cbxCategoria.DisplayMember = "cat_descricao";
            cbxCategoria.ValueMember = "cat_id";

        }
         private void CarregaTabela() //private void button1_Click(object sender, EventArgs e)  
        {
            dgvDados.DataSource = null;
            DataTable dados = con.Retorna("select prod_codigo, prod_nome, " + ]
                "prod_descricao, cat_descricao, prod_valor" +
                "from tb_produto inner join tb_categoria on prod_categoria=cat_id");
            dgvDados.DataSource= dados;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from tb_produto where prod_id=" +
                txtCodigo.Text;
            if (con.Executar(sql))
            {
                MessageBox.Show("Excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao Excluir!");
            }
            CarregaTabela();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sql = "update tb_produto set prod_nome'" +
                txtNome.Text + "',prod_descricao='" + txtDescricao.Text +
                "',prod_categoria=" + cbxCategoria.SelectedValue +
                ", prod_valor=" + Convert.ToDouble(txtValor.Text)
                + "where prod_codigo=" + txtCodigo.Text;
            if (con.Executar(sql))
            {
                MessageBox.Show("Atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar!");
            }
            CarregaTabela();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into tb_produto values(null, '" +
        txtNome.Text + "', '" + txtDescricao.Text + "', " +
        cbxCategoria.SelectedValue + ", " + txtValor.Text + ")";
            if (con.Executar(sql))
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

         private void TelaProduto_Load(object sender, EventArgs e)
        {
            CarregaCategoria();
            CarregaTabela();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable dados = con.Retorna("select * from tb_produto" +
                    "where prod_codigo=" + txtCodigo.Text);
                txtNome.Text = dados.Rows[0]["prod_nome"].ToString();
                txtDescricao.Text = dados.Rows[0]["prod_descricao"].ToString();
                cbxCategoria.SelectedValue = Convert.ToInt32(
                    dados.Rows[0]["prod_categoria"]);
                txtValor.Text = dados.Rows[0]["prod_valor"].ToString();
            }
        }
    }
}
