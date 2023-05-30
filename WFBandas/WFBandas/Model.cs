using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; // não esquecer de adicionar a referência no projeto.
using MySql.Data.MySqlClient;  // não esquecer de adicionar a referência no projeto.
using System.Windows.Forms; // para o messagebox funcionar dentro de classes que não são WindowsForm

namespace WFBandas
{
    class Model
    {
        /* atributos = variáveis públicas que servem para todos 
         * os métodos da classe e do projeto */
        public String servidor = "localhost";
        public String usuario = "root";
        public String senha = "vertrigo";
        public String banco = "bd_bandas";
        public MySqlDataReader Resultado; // vetor que retorna os valores de uma tabela

        
        public void OperacoesSQL(String sql){        
            //Método para INSERT, UPDATE e DELETE;
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=" + servidor +";database=" + banco + "; Uid=" + usuario + "; pwd=" + senha);
                conectar.Open();
                MySqlCommand Comando = new MySqlCommand();
                Comando.Connection = conectar;
                Comando.CommandText = sql;
                Comando.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("Operação realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
        

        public void ConsultaSQL(String sql)
        {
            // Método para consulta, tbm serve para DataGrids e Comboboxes;
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=" + servidor + ";database=" + banco + "; Uid=" + usuario + "; pwd=" + senha);
                conectar.Open();
                MySqlCommand Consulta = new MySqlCommand();
                Consulta.Connection = conectar;
                Consulta.CommandText = sql;
                Resultado = Consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
            }
        }
    }
}
