using System.Dynamic;
using Programa_003.Models;

//Fazendo uma copia da class padrão
//Pessoa Pessoa1 = new Pessoa();

/* Aqui é o Set */
/* 
Pessoa1.Nome = "Robert";
Pessoa1.SobreNome = "Gabriel";
Pessoa1.Idade = 21;
Pessoa1.Apresentar();
 */

/* Quando aparece uma caixa na sugestão é um metodo, se for uma chave inglesas é uma propriedade */



/* >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> */
/* Método é um conjunto de instruções */
/* Exemplo: Apresentar() */

/* Class Curso

--- Atributos ---
Nome 
Alunos: List <Pessoa>

--- Método ---

Adicionar()
Remover()
ListaDeAlunos()
ObterAlunosMatriculados()

// Lista<tipo da lista> nome da lista = nova lista <tipo string> (capacidade da Lista, não é obrigatório passar a capacidade da lista)
 */

Pessoa Pessoa1 = new Pessoa();
Pessoa1.Nome = "Robert";
Pessoa1.SobreNome = "Gabriel";


Pessoa Pessoa2 = new Pessoa();
Pessoa2.Nome = "Elisa";
Pessoa2.SobreNome = "Beatriz";


Curso NovoCurso = new Curso();

NovoCurso.NomeDoCurso = "Curso de C#";
NovoCurso.Alunos = new List<Pessoa>();

NovoCurso.AdicionarAluno(Pessoa1);
NovoCurso.AdicionarAluno(Pessoa2);
NovoCurso.ListarAlunos();

















