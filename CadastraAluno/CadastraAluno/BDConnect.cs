using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CadastraAluno
{
    class BDConnect
    {
        public string user { private set; get; }
        public string passwd { private set; get; }
        public string bd { private set; get; }
        public string server { private set; get; }
        public string error;
        public MySqlConnection conn { private set; get; }
        public BDConnect(String user, String passwd, String bd, String server) {
            this.user = user;
            this.passwd = passwd;
            this.bd = bd;
            this.server = server;
        }
        //conecta com o bd
        public bool ConnectBD()
        {
            conn = new MySqlConnection("user = "+user+"; pwd = "+passwd+"; database  = "+bd+"; server = "+server+"");
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception e){
                error = e.StackTrace;
                return false;
            }
        }
        public bool desconnectBD() {
            try
            {
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //cadastra aluno
        public bool Cadastrar(Aluno aluno) {
            string query = "insert into aluno (nome, matricula, CPF, nascimento) values (@nome, @matricula, @CPF, @nascimento);";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.Parameters.AddWithValue("@cpf", aluno.CPF);
                cmd.Parameters.AddWithValue("@nome", aluno.nome);
                cmd.Parameters.AddWithValue("@matricula", aluno.matricula);
                cmd.Parameters.AddWithValue("@nascimento", aluno.data_nasc);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e){
                error = e.StackTrace;
                return false;
            }
        }
        //cadastra turma
        public bool Cadastrar(Turma turma) {
            string query = "insert into turma (nome, sala) values (@nome, @sala);";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.Parameters.AddWithValue("@sala", turma.sala);
                cmd.Parameters.AddWithValue("@nome", turma.nome);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
