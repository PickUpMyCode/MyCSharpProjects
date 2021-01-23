using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Florzinha
{
    class MysqlDataRequest
    {
        public static string logError { private set; get; }
        //Retorna os produtos da loja
        //Consulta os dados de acordo com o valor do combobox
        public static List<Funcionario> getByDropdown(MySqlConnection c, Funcionario f) {
            List<Funcionario> funcionarios = new List<Funcionario>();
            string query = "select * from funcionario where cpf = '"+f.cpf+"' or nome = '"+f.nome+"' or funcao = '"+f.funcao+"';";
            MySqlCommand com = new MySqlCommand(query, c);
            try {
                MySqlDataReader r = com.ExecuteReader();
                while (r.Read()) {
                    Funcionario fun = new Funcionario(long.Parse(r["cpf"].ToString()), r["nome"].ToString(), r["funcao"].ToString(), char.Parse(r["genero"].ToString()), double.Parse(r["salario"].ToString()), DateTime.Parse(r["nascimento"].ToString()));
                    funcionarios.Add(fun);
                }
                r.Close();
                return funcionarios;
            }
            catch (Exception e) {
                logError = e.StackTrace;
                return null;
            }
        }
        //Consulta os dados de acordo com o valor do textbox
        public static List<Produto> getByTextbox(MySqlConnection c, Produto prod)
        {
            List<Produto> produtos = new List<Produto>();
            string query = "select * from produto where nome  = '"+prod.nomeprod+"'";
            MySqlCommand com = new MySqlCommand(query, c);
            try
            {
                MySqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Produto p = new Produto(int.Parse(r["cod_produto"].ToString()),r["nome"].ToString(), double.Parse(r["custo"].ToString()), int.Parse(r["qntd"].ToString()), r["marca"].ToString());
                    produtos.Add(p);
                }
                r.Close();
                return produtos;
            }
            catch (Exception e)
            {
                logError = e.StackTrace;
                return null;
            }
        }
        //testa por nome e marca
        //Consulta os dados de acordo com o valor do combobox
        public static List<Produto> getByDropdown(MySqlConnection c, Produto prod)
        {
            List<Produto> produtos = new List<Produto>();
            string query = "select * from produto where marca = '"+prod.marca+"' or nome = '"+prod.nomeprod+"'";
            MySqlCommand com = new MySqlCommand(query, c);
            try
            {
                MySqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Produto p = new Produto(int.Parse(r["cod_produto"].ToString()), r["nome"].ToString(), double.Parse(r["custo"].ToString()), int.Parse(r["qntd"].ToString()), r["marca"].ToString());
                    produtos.Add(p);
                }
                r.Close();
                return produtos;
            }
            catch (Exception e)
            {
                logError = e.StackTrace;
                return null;
            }
        }
        //retorna os dados para adicionar nos items do combobox
        public static List<Produto> AddDrop(MySqlConnection c) {
            List<Produto> produtos = new List<Produto>();
            string query = "select nome, marca from produto;";
            MySqlCommand com = new MySqlCommand(query, c);
            try
            {
                MySqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Produto p = new Produto(r["nome"].ToString(), r["marca"].ToString());
                    produtos.Add(p);
                }
                r.Close();
                return produtos;
            }
            catch (Exception e){
                logError = e.StackTrace;
                return null;
            }
        }
        public static List<Funcionario> AddDropFunc(MySqlConnection c)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            string query = "select cpf, nome, funcao from funcionario;";
            MySqlCommand com = new MySqlCommand(query, c);
            try
            {
                MySqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Funcionario fun = new Funcionario( long.Parse(r["cpf"].ToString()), r["nome"].ToString(), r["funcao"].ToString());
                    funcionarios.Add(fun);
                }
                r.Close();
                return funcionarios;
            }
            catch (Exception e)
            {
                logError = e.StackTrace;
                return null;
            }
        }
    }
}

