using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa_003.Models
{
    public class Curso
    {
        public string NomeDoCurso { get; set; }

        // Lista<tipo da lista> nome da lista = nova lista <tipo string> (capacidade da Lista, não é obrigatório passar a capacidade da lista)
        public List<Pessoa> Alunos { get; set; }

/* o public não faz parte da assinatura do método */
/* void (não retorna valor) é o tipo do método, e quando eu não quero retorno do método eu uso o void */
/* AdicionarAluno é o nome da método */
/* Entre os parenteses é onde está os paremetros  */
/* Pessoa é uma Class e Alunos é uma lista */
        public void AdicionarAluno(Pessoa aluno){
            
            /* Aqui ésta adicionado aluno para Class Alunos */
            Alunos.Add(aluno);

        }

        public int ObterQuantidadeDeAlunos () /* Abri e fecha parenteses é obrigadores, mas passar parametros é opcional */{

            int totalDeAlunos = Alunos.Count
            /* Todo método que tem retorno precisa colocar return */;
            /* o valor da variavel totalDeAlunos vai retorna para o método ObterQuantidadeDeAlunos */
            return totalDeAlunos;

        }

        public bool RemoverAlunos(Pessoa aluno){

            return Alunos.Remove(aluno);

        }

        public void ListarAlunos(){

            Console.WriteLine($"Alunos(a) do {NomeDoCurso}: ");
            foreach (Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

    }
}