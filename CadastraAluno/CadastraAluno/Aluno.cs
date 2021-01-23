using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastraAluno
{
    class Aluno
    {
        public String nome { private set; get; }
        public String CPF { private set; get; }
        public int matricula { private set; get; }
        public DateTime data_nasc { private set; get; }
        public Aluno(String nome, String CPF, int matricula, DateTime data_nasc) {
            this.nome = nome;
            this.CPF = CPF;
            this.matricula = matricula;
            this.data_nasc = data_nasc;
        }

    }
}
