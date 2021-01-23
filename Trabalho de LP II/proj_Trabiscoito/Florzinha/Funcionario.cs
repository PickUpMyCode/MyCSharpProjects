using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florzinha
{
    class Funcionario

    {
        public long cpf { private set; get; }
        public string nome { private set; get; }
        public string funcao { private set; get; }
        public char genero { private set; get; }
        public double salario { private set; get; }
        public DateTime nascimento { private set; get; }
        public Funcionario(long cpf, string nome, string funcao, char genero, double salario, DateTime nascimento) {
            this.cpf = cpf;
            this.nome = nome;
            this.genero = genero;
            this.funcao = funcao;
            this.salario = salario;
            this.nascimento = nascimento;
        
        }
        //Serve apenas para diferenciar as assinaturas
        public Funcionario(int noarg , string funcao) {
            this.funcao = funcao;
        }
        public Funcionario(long cpf) {
            this.cpf = cpf;
        }
        public Funcionario(long cpf, double salario, string funcao) {
            this.cpf = cpf;
            this.funcao = funcao;
            this.salario = salario;
        }
        public Funcionario(long cpf, string nome, string funcao) {
            this.nome = nome;
            this.cpf = cpf;
            this.funcao = funcao;
        }
        public Funcionario(string nome) {
            this.nome = nome;
        }
    }
}
