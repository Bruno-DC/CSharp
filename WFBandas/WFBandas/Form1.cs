using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBandas
{
    public partial class Form1 : Form
    {

        Model model = new Model(); // instancia.


        public void CarregaGrid(string sql)
        {
            // Classe para Popular o Grid no load, no insert, no update e no delete.
            model.ConsultaSQL(sql); //----> chama o método de consulta
            dtDados.Rows.Clear(); //----> limpa os dados do grid para remover consultas anteriores
            if (model.Resultado.HasRows)
            {
                while (model.Resultado.Read())
                {
                    dtDados.Rows.Add(model.Resultado["banda_nome"].ToString(),
                                     model.Resultado["banda_estilo"].ToString(),
                                     model.Resultado["banda_ano"].ToString());
                }
            }
        }
                
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from tb01_bandas ORDER BY banda_nome";            
            CarregaGrid(sql);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtNomeBanda.Text != "")
            {
                //Insere dados no banco
                string sql = "INSERT INTO `tb01_bandas` ( `banda_nome`, `banda_estilo`, `banda_ano`, `banda_descricao`)"
                                              + "VALUES ('" + txtNomeBanda.Text + "','" + cbEstilo.Text + "', '" + txtAnoBanda.Text + "',     '" + txtDescricao.Text + "');";
                model.OperacoesSQL(sql);

                //Atualiza DataGridView após o INSERT
                sql = "SELECT * from tb01_bandas ORDER BY banda_nome";                
                CarregaGrid(sql);
            }
            else
            {
                MessageBox.Show("Informe o nome da banda");
                txtNomeBanda.Focus();
            }

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            // inicia o formulário com o grid já populado.
            string sql = "SELECT * from tb01_bandas WHERE banda_nome LIKE '%" + txtPesquisar.Text + "%' ORDER BY banda_nome";
            CarregaGrid(sql);
        }
    }
}
