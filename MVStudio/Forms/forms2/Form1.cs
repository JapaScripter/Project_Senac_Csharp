using MySql.Data.MySqlClient;
using System.Data;

namespace forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "";
            MySqlConnection conn = null;
            string consulta = "";
            try
            {
                connection = "server=localhost;username=root;password=;database=db_produto";
                conn = new MySqlConnection(connection);
                consulta = $"SELECT * FROM tb_produtos WHERE id_produto = '{tb_id.Text}'";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                conn.Open();
                DataSet ds = new DataSet();
                MySqlDataAdapter dta = new MySqlDataAdapter(cmd);
                dta.Fill(ds);
                tb_produto.Text = ds.Tables[0].Rows[0][1].ToString();
                tb_preco.Text = ds.Tables[0].Rows[0][2].ToString();
                tb_quantidade.Text = ds.Tables[0].Rows[0][3].ToString();
                MessageBox.Show("Registro selecionado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "";
            MySqlConnection conn = null;
            string consulta = "";
            try
            {
                connection = "server=localhost;username=root;password=;database=db_produto";
                conn = new MySqlConnection(connection);
                consulta = $"UPDATE tb_produtos SET produto = '{tb_produto.Text}', preco = '{tb_preco.Text}', quantidade = '{tb_quantidade.Text}' WHERE id_produto = '{tb_id.Text}'";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                tb_produto.Text = String.Empty;
                tb_preco.Text = String.Empty;
                tb_quantidade.Text = String.Empty;
                MessageBox.Show($"Registro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connection = "";
            MySqlConnection conn = null;
            string consulta = "";
            try
            {
                connection = "server=localhost;username=root;password=;database=db_produto";
                conn = new MySqlConnection(connection);
                consulta = $"DELETE FROM tb_produtos WHERE id_produto = '{tb_id.Text}'";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                tb_produto.Text = String.Empty;
                tb_preco.Text = String.Empty;
                tb_quantidade.Text = String.Empty;
                MessageBox.Show($"Registro apagado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "";
            MySqlConnection conn = null;
            string consulta = "";
            try
            {
                connection = "server=localhost;username=root;password=;database=db_produto";
                conn = new MySqlConnection(connection);
                consulta = $"INSERT into tb_produtos(produto,preco,quantidade)values('{tb_produto.Text}','{tb_preco.Text}','{tb_quantidade.Text}')";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                tb_produto.Text = String.Empty;
                tb_preco.Text = String.Empty;
                tb_quantidade.Text = String.Empty;
                MessageBox.Show($"Registro produto = {tb_produto.Text}, preço = {tb_preco.Text} e quantidade = {tb_quantidade.Text}, inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
