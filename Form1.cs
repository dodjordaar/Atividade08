using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Relacionamentoapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpar()
        {
            tb_nome.Clear();
            tb_email.Clear();
            tb_contato.Clear();
            cb_sexo.SelectedIndex = -1;
            cb_pref.SelectedIndex = -1;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=client_info;Integrated Security=True";
            comando.Connection = conexao;
            comando.CommandText = "insert into tb_clienteinfo (nome_clienteinfo, email_clienteinfo, contato_clienteinfo, sexo_clienteinfo, pref_clienteinfo) values " +
                "(@nome_clienteinfo,@email_clienteinfo,@contato_clienteinfo,@sexo_clienteinfo,@pref_clienteinfo)";
            comando.Parameters.AddWithValue("@nome_clienteinfo", tb_nome.Text);
            comando.Parameters.AddWithValue("@email_clienteinfo", tb_email.Text);
            comando.Parameters.AddWithValue("@contato_clienteinfo", tb_contato.Text);
            comando.Parameters.AddWithValue("@sexo_clienteinfo", cb_sexo.Text);
            comando.Parameters.AddWithValue("@pref_clienteinfo", cb_pref.Text);
            int LinhasAfetadas = 0;
            limpar();
            try
            {
                conexao.Open();
                LinhasAfetadas = comando.ExecuteNonQuery();

            }
            catch(Exception exception)
            {
                MessageBox.Show("A conexão com o banco não foi alcançada.");
            }
            finally
            {
                conexao.Close();
                MessageBox.Show($"Registro efetuado.\n" +
                    $"Linhas afetadas: {LinhasAfetadas} ");
            }

        }
    }
}
