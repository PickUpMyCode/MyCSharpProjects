using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Florzinha
{
    class MysqlDatabase
    {
        public static MySqlConnection conn { private set; get; }
        public static string logError { private set; get; }

        //Conectando e desconectando com o banco de dados
        public static bool Connectar() {
            conn = new MySqlConnection("user = root; pwd = ''; database = loja_florzinha; server = localhost;");
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception e) {
                logError = e.StackTrace;
                return false;
            }
        }
        public static bool Desconectar() {
            try {
                conn.Close();
                return true;
            }
            catch (Exception e) {
                logError = e.StackTrace;
                return false;
            }
        }

        //Cadastrar

        [Obsolete]
        public static bool Cadastrar(Produto p) {
           string query = "insert into produto (nome, marca, custo, qntd) values (@nome, @marca, @custo, @qntd);";
            MySqlCommand c = new MySqlCommand(query, conn);
            try
            {
                c.Parameters.AddWithValue("@nome", p.nomeprod);
                c.Parameters.AddWithValue("@marca", p.marca) ;
                c.Parameters.AddWithValue("@custo", p.custo);
                c.Parameters.AddWithValue("@qntd", p.qntd);
                c.ExecuteNonQuery();
                return true;
            }
            catch (Exception e ) {
                logError = e.StackTrace;
                return false;
            }
        }
        public static bool Cadastrar(Funcionario f)
        {
             string query = "insert into funcionario (cpf, nome, genero, salario, funcao, nascimento) values (@cpf, @nome, @genero, @salario, @funcao, @nascimento);";
            MySqlCommand c = new MySqlCommand(query, conn);
            try
            {
                c.Parameters.AddWithValue("@cpf", f.cpf);
                c.Parameters.AddWithValue("@nome",f.nome);
                c.Parameters.AddWithValue("@genero", f.genero);
                c.Parameters.AddWithValue("@salario", f.salario);
                c.Parameters.AddWithValue("@nascimento", f.nascimento);
                c.Parameters.AddWithValue("@funcao", f.funcao);
                c.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                logError = e.StackTrace;
                return false;
            }
        }

        //Deletar
        public static bool Deletar(Produto p) {
            string query = "delete from produto where marca = @marca or nome = @nome;";
            MySqlCommand c = new MySqlCommand(query, conn);
            try {
                c.Parameters.AddWithValue("@marca", p.marca);
                c.Parameters.AddWithValue("@nome", p.nomeprod); ;
                if (c.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e) {
                logError = e.StackTrace;
                return false;
              }
        }
        public static bool Deletar(Funcionario f) {
            string query = "delete from funcionario where cpf = '"+f.cpf+"'";
            MySqlCommand com = new MySqlCommand(query, conn);
            try {
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                logError = e.StackTrace;
                return false;
            }
       
        }
        //Alterar
        public static bool Alterar(Produto p) {
           string query = "update produto set custo = @custo , qntd = @qntd where cod_produto = @cod_produto;";
            MySqlCommand c = new MySqlCommand(query,conn);    
            try {
                c.Parameters.AddWithValue("@cod_produto", p.cod_produto);
                c.Parameters.AddWithValue("@custo", p.custo);
                c.Parameters.AddWithValue("@qntd", p.qntd);
                c.ExecuteNonQuery();
                return true;
            }catch(Exception e){
                logError = e.StackTrace;
                return false;
            }
        }
        public static bool Alterar(Funcionario f) {
            string query = "update funcionario set funcao = @funcao , salario = @salario where cpf = @cpf";
            MySqlCommand com = new MySqlCommand(query, conn);
            try {
                com.Parameters.AddWithValue("@funcao", f.funcao);
                com.Parameters.AddWithValue("@cpf", f.cpf);
                com.Parameters.AddWithValue("@salario", f.salario);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                logError = e.StackTrace;
                return false;
            }
        }

    }
}
