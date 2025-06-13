using System.Data;
using MySql.Data.MySqlClient;

namespace Sistema_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "";
            MySqlConnection conn = null;
            string consulta = "";
            try
            {
                connection = "server=localhost;username=root;password=;database=db_aula";
                conn = new MySqlConnection(connection);
                consulta = $"INSERT INTO tb_login(nome,email,senha)VALUES('{TB_Nome.Text}','{TB_Email.Text}','{TB_Senha.Text}')";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Foi adicionado o email {TB_Email.Text} e a senha {TB_Senha.Text}");
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
                connection = "server=localhost;username=root;password=;database=db_aula";
                conn = new MySqlConnection(connection);
                consulta = $"UPDATE tb_login SET nome = '{TB_Nome.Text}', email = '{TB_Email.Text}', senha = '{TB_Senha.Text}' WHERE id = '{TB_ID.Text}'";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connection = "";
            MySqlConnection conn = null;
            string consulta = "";
            try
            {
                connection = "server=localhost;username=root;password=;database=db_aula";
                conn = new MySqlConnection(connection);
                consulta = $"SELECT * FROM tb_login WHERE id = '{TB_ID.Text}'";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                conn.Open();
                DataSet ds = new DataSet();
                MySqlDataAdapter dta = new MySqlDataAdapter(cmd);
                dta.Fill(ds);
                TB_Nome.Text = ds.Tables[0].Rows[0][1].ToString();
                TB_Email.Text = ds.Tables[0].Rows[0][2].ToString();
                TB_Senha.Text = ds.Tables[0].Rows[0][3].ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "";
            MySqlConnection conn = null;
            string consulta = "";
            try
            {
                connection = "server=localhost;username=root;password=;database=db_aula";
                conn = new MySqlConnection(connection);
                consulta = $"DELETE FROM tb_login WHERE id = '{TB_ID.Text}'";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
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
    }
}
