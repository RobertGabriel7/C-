//Para encontrar a class em outra pasta/arquivo
using C_Sharp.Models;
using Microsoft.VisualBasic;

//>>>>>>>>>>>>>>>>>>>>> VARIAVEIS <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

//nome da classe - variavel - classe
//Quando declara variavel precisa ser em camelCase. Por exemplo: carroMaisCaroDaLoja = "Ferrari 458"
//O nome da variavel não pode conter caractere especial em seu nome, apenas underline_ 
//As variaveis podem ser declaradas somente uma vez por escopo. Não pode declarar mais de uma variavel dentro do mesmo escopo.
//Quando coloca o tipo da variavel quer dizer que você está declarando ela pela primeira vez. Se não declarar o tipo, quer dizer que você está alterando o valor da varivael que já existe no escopo. 

//Por exemplo:
// string eitaFi = "Fala meus queridos"
// eitaFi = "Fala meus amigos"


Pessoa testeDeClass = new Pessoa();

testeDeClass.Nome = "Robert Gabriel";


//Esse ponto significa continuidade de uma ação
testeDeClass.Idade = 21;

//Todo método tem ()
testeDeClass.Apresentar();


//************************************* UTILIDADE **********************************************

//Ctrl k c - faz comentarios


//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

//Sintaxe é a regra estabelicida pela linguagem. Então cada linguagem tem a sua Sintaxe.
//As convenções são as regras definidas pela comunidade para que o código tenha legibilidade.
//E cada linguagem também tem a sua convenção

//>>>>> Um ponto importante é a legibilidade do código para que qualquer outra pessoa possa entender. <<<<<

//char representa um único caractere


//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

// Exemplo de declaração de variáveis
int idade = 25;           // Variável do tipo int para números inteiros
double altura = 1.80;     // Variável do tipo double para números decimais
string nome = "João";     // Variável do tipo string para texto
bool ehEstudante = true;  // Variável do tipo bool para valores booleanos (verdadeiro ou falso)
char letra = 'a';         // Representa um único caractere
decimal dinheiro = 10.50M;  // Para Dinheiro



Console.WriteLine("Idade: " + idade );

//ToString("0.00") vai representa um numero inteiro e dois decimais
Console.WriteLine("Altura: " + altura.ToString("0.00"));
Console.WriteLine("Nome: " + nome);
Console.WriteLine("É estudante: " + ehEstudante);
Console.WriteLine("Um único caractere: " + letra);
Console.WriteLine("Quantos reais: R$" + dinheiro);

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

//Mostra o dia, mês, ano e hora, minutos e segundos. 20/12/2023 23:13:45
DateTime dataAtual = DateTime.Now;

//Nesse caso, vai Adcionar um ano a mais na data atual
DateTime ano = DateTime.Now.AddYears(1);


Console.WriteLine(dataAtual);

//Imprime somente a data: dia, mes e ano.
Console.WriteLine(dataAtual.ToString("dd/mm/yyyy"));

//Imprime a data e o horario: dia, mes e ano e hora e minutos.
Console.WriteLine(dataAtual.ToString("dd/mm/yyy  hh:mm"));

Console.WriteLine(ano);