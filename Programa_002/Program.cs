/*
/// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Diagnostics;
using Programa_002.Models;



Console.WriteLine("Hello, World!");

//Cast - Casting - Processo de converte


// Para converte string para int 

// Convert é uma Class e ToInt32 é um método
// int nu = Convert.ToInt32("5") ;

// Uma maneira semelhante para converte uma string para int
int nu = int.Parse("5");

decimal num = decimal.Parse("5.15");


// Nesse caso abaixo, vai mostrar uma mensagem de erro por tem um numero e uma letra e por isso não possivel converte uma letra para int
// int nu = int.Parse("5c");

Console.WriteLine(nu);

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

//Convert.ToInt32(null); vai converte o valor nulo para zero, mas não vai dar erro.

//int.Parse(null); não aceita valor nulo, vai encerrar o programa

// O converte é melhor porque vai retornar um valor e não vai encerrar o programa

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

int inteiro = 5;

//Nesse caso, vai converte o valor inteiro para string.

//string a = Convert.ToString(inteiro);

string a = inteiro.ToString();

//Para string não tem Parse, só o Convert, e o ToString tem em tudo no C#

Console.WriteLine(a);

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

//Cast implicito

//Valor inteiro
int nume = 5;

//Valor fracionado, com casas decimais
double nu1 = nume;

//A converção está sendo feita automaticamente porque o int cabe no double. Mesmo sendo de tipos diferentes 


//Int tem valores até Bilhões
int a1 = 5;

//Log tem valores até Trilhões
long g = a1;

//Se for o contrario de log para int, n vai funcionar porque log é maior

long g1 = 5;
int cd = Convert.ToInt32(g1);

//Valor maixmo de long: long.MaxValue;

//long rt = long.MaxValue;

int ma = int.MaxValue;
long max = ma;

Console.WriteLine(nu1);
Console.WriteLine(g);
Console.WriteLine(cd);
Console.WriteLine(max);

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


//O C# sgue a ordem dos operadores igual na matematica.

string aaa = "15 ";




// int;tryParse(a) vai tentar converte a variavel 'aaa' mas se nao der certo a saida vai ser a variavel 'b'

// Caso de certo a converção, a variavel 'b' vai receber o valor da variavel 'aaa' como int 

//int b = 0;
//int.TryParse(aaa, out b);

//Outra opção:


//ja cria a variavel 'b' do tipo inteiro com o valor 0 que é o valor padrão.
int.TryParse(aaa, out int b);

//Precisa mostrar a variavel 'b' porque independente do resultado, saida vai ser a variavel 'b'.
Console.WriteLine(b);
Console.WriteLine("Converção com sucesso");

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
//OPERADORES CONDFICIONAIS - possibilidade de de mudar o fluxo de execução de seu código, indicando um caminha que ele deve percorrer.


//OPERADORES: IF 

Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");



int quantidade = 100;

Console.WriteLine("Digite a quantidade solicitada: ");

int solici =  Convert.ToInt32(Console.ReadLine());

if (solici == 0 ){

Console.WriteLine("Compra invalida.");

}

//Se não se 
else if (solici <= quantidade)
{
    //Vai mostrar a variavel dentro da string ($"Texto qualquer {variavel} texto qualquer")
    Console.WriteLine($"A quantidade solicitada foi de {solici}, tem para comprar e restou {quantidade - solici} no estoque.");
    
}else
{
    Console.WriteLine($"A quantidade solicitada foi de {solici} e excedeu o limite do estoque que é {quantidade}.");
    
}   
//Aqui tem o pulo do gato, vai verificar se a solicitação de compra é maior que 0
 Console.WriteLine(value: $"A compra foi realizada: {solici > 0 && solici <= quantidade}");

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

//SWITCH

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
//É possivel fazer dessa maneira, mas não tao boa asssim

//Console.WriteLine("Digite uma letra: ");

//string letra =  Console.ReadLine(); 

//string letra = Console.ReadLine();

//if(
//letra  == "a" || 
//letra  == "e" ||
//letra  == "i"  ||
//letra  == "o" ||
//letra  == "u" ){

//Console.WriteLine($"A letra digitada foi '{letra}' e é uma vogal.");

//}else{
//    Console.WriteLine($"A letra digitada foi '{letra}' e não é uma vogal, mas sim, uma consoante .");
//}

Console.WriteLine("Digite uma letra: ");
string letra =  Console.ReadLine(); 
switch (letra){

//Precisa colocar dois pontos
case "a":
case "e":
case "i":
case "o":
case "u":
    //Se algum case foi verdadeiro vai executar o que tiver depois dos dois pontos e break(vai parar a execução do Switch)    
    Console.WriteLine($"A letra digitada foi '{letra}' e é uma vogal.");
    break;

//Default é caso os cases não forem verdadeiro, a saida vai ser default(padrão)
default:
    
    Console.WriteLine($"A letra digitada foi '{letra}' e não é uma vogal, mas sim, uma consoante .");
    break;

}

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> 
//OPERADOR OR (Piper, || )

//Só é False quando todos forem False
Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

Console.WriteLine("É maior de idade, True or Flase? ");
bool deMaior = Convert.ToBoolean(Console.ReadLine());


 
if( deMaior == true){

    Console.WriteLine("Entrada permitida.");
//Se for verdadeiro, o codigo termina aqui, se nao
}

 else  {
//Aqui vai perguntar e agregar o valor boolean para a variavel auto
Console.WriteLine("Tem autorização, True or Flase?  ");
bool auto = Convert.ToBoolean( Console.ReadLine());

//Aqui vai verificar se deMaior ou auto são verdadeiro
if(deMaior || auto){

//Se deMaior for false e auto for verdadeiro, vaii imiprimir esse resultado

Console.WriteLine("Mesmo sendo de menor, a entrada é permitida por causa da autorização dos seus pais.");

//Se deMaior e auto for false, vai imiprimir esse resultado.

}else {

Console.WriteLine("Por ser de menor e não ter autorização, a entrada não é permitida.");

}
 }

 // Para Criar comentarios no codigo selecionado: shift alt a  


 Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
  
  
 //Operador AND só retorna verdadeiro se todos forem verdadeiros;


Console.WriteLine("Qual foi a nota do aluno? ");

double nota = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Possui presença minima: true or false ? ");

bool possuiPreMininina = Convert.ToBoolean(Console.ReadLine());

if (nota >= 5 && possuiPreMininina ){


Console.WriteLine($"Parabens, o aluno ficou com a nota {nota} e foi aprovado.");

}else {

if (nota >= 5 && possuiPreMininina == false) {

Console.WriteLine($"A sua nota foi {nota}, cima de 5, porem foi reprovado por não ter presença minina. ");

}else{

Console.WriteLine($"A sua nota foi {nota} e por isso você não foi aprovado. ");

}

}

Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");


//OPERADOR NOT, inverte os valores.

//Por exemplo: se for true, vira false 
//se for false, vira true


bool choveu = false;
bool estaTarde = false;

// o ponto de exclamação ! é um sinal de negação, sinal de NOT.
if(!choveu && !estaTarde){

Console.WriteLine("Vou pedalar");

}else{
Console.WriteLine("Não vou pedalar hoje.");
}



  int soma = 5 + 3;
        Console.WriteLine("Soma: " + soma);  // resultado será 8

        // Operador de Subtração
        int subtracao = 5 - 3;
        Console.WriteLine("Subtração: " + subtracao);  // resultado será 2

        // Operador de Multiplicação
        int multiplicacao = 5 * 3;
        Console.WriteLine("Multiplicação: " + multiplicacao);  // resultado será 15

        // Operador de Divisão
        int divisao = 6 / 3;
        Console.WriteLine("Divisão: " + divisao);  // resultado será 2

        // Operador de Módulo
        int modulo = 7 % 3;
        Console.WriteLine("Módulo: " + modulo);  // resultado será 1

        // Operador de Incremento
        int a = 5;
        
        Console.WriteLine("Incremento: ",  a);  // a agora é 6

        // Operador de Decremento
        int b = 8;
        
        Console.WriteLine("Decremento: " + b);  // b agora é 7

 

Teste calc = new Teste();

Console.WriteLine(calc.Somar(125, 15));

//Potencia
calc.Potencia(10.12, 52.12);

//Raiz Quadrada
calc.RaizQuadrada(50);

Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

//F12 para mais informações 


int numero55 = 10;

//Incrementando o numero 10
//o valor vai ser 11
numero55++;

//Decrementando o nuemro 10;
//o valor vai ser 9
int numer = 10;
numer--;


//ESTRUTURA DE REPETIÇÃO
//FOR, WHILE e DO WHILE



//REPETIÇÃO FOR.

//for: Use quando souber antecipadamente quantas iterações precisa. É eficiente para percorrer sequências com um índice ou contador.

Console.WriteLine("Tabuada de qual número:  ");
int numeroDaTabuada = Convert.ToInt32(Console.ReadLine());

//for (a declaração da variavel, condição da variavel e Incrementando )
//A variavel contador vai começar do 0 e vai até 10, e é acrescentado mais 1 na variavel contador (para chegar até 10)
//Verifica o contador, se for menor 10 o código vai rodar, vai voltar e acrescentar mais um no contador se não passar do valor 10 

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numeroDaTabuada} x {contador} é: {numeroDaTabuada * contador}");
}


//REPETIÇÃO WHILE (Enquanto...)

//while: Use quando a condição de término ou continuação não puder ser determinada antecipadamente. É útil quando a lógica de controle é simples.

//Ctrl C para interroper o terminal quando estiver em execução


Console.WriteLine("Tabuada de qual número:  ");
int numeroDaTabua = Convert.ToInt32(Console.ReadLine());

int cont = 0;

//Enquanto cont for menor ou igual a 10, vai executar o código
//Verifica primeiro se o cont é verdadeiro para prosseguir a execução do código
while (cont <= 10){

Console.WriteLine($"{numeroDaTabua} x {cont} é: {numeroDaTabua * cont}");

cont++;

//Para fazer uma interrupição na execução do código
//Vai parar na Tabuada do 7 porque começa do 0.
if(cont >= 8){
    break;
}

}



//REPETIÇÃO DO WHILE
//do-while: Semelhante ao while, mas garante que o bloco de código seja executado pelo menos uma vez, mesmo se a condição for falsa desde o início.
//Vai executar o código independente da condição 

int numero44 = 0;

do{
    Console.WriteLine("Digite um numero (o numero 0 para a execução do programa)");
    int numeroDigitado = Convert.ToInt32(Console.ReadLine());
    numero44 = numeroDigitado;

//Enquanto o numero foi diferente de 0, o programa vai continuar. Se não for diferente de 0, vai voltar para o Do
}while(numero44 != 0);

Console.WriteLine("Fim da execução do programa.");



//Sinal de diferente !=

//Vai pegar o valor da variavel numero e ADICIONAR na variavel soma.
// soma += numero

//Environment.Exit(0); para encerrar totalmente o programa. E não vai executar o código abaixo.

//Para encerrar o programa de outra maneira: 
//exibirMenu = false: 
//Break:
//O código abaixo vai ser executado

//Console.Clear(); para limpar o programa
*/

//ARRAY (matriz, ou vetor) e LISTAS

//Array é uma estrutura de dados que armazenam elementos do mesmo tipo 
//Semelhante a uma varivael, o array armazena variaveis dentro dele e elas podem ser acessadas pelo o seu inidice.

//Uma variavel com diversos valores

//Aqui vai passat o tamanho do array (5 indices)
int[] array = new int[4];

array[0] = 10;
array[1] = 20;
array[2] = 30;
array[3] = 40;

Console.WriteLine("FOR");

//.Length vai mostrar o ultimo indice do array

for (int indice = 0; indice < array.Length; indice++ ){

Console.WriteLine($"Indice do array {indice}° - {array[indice]}");

}


//Inves da falar o tamanho, pode colocar os dados e o programa vai saber que é um array com 5 indices porque foram colocados 5 dados 

//int[] array2 = new int{42,77,35,26, 78};

//Ctrl : faz comentarios

string[] nomes = {"Jan","Fev "};

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);

//FOREACH
Console.WriteLine("FOREACH");
//Semelhante a esse código: for (int indice = 0; indice < array.Length; indice++ , mas resumido...

//Compilado é quando o código já esta rodando e não pode mexer 
//Para cada elemento do array, joga o valor para a variavel valor 

foreach (int valor22 in array)
{
    Console.WriteLine(valor22);
}

Console.WriteLine("Para mudar o tamanho do Array");


//ref é o endereço da memoeria do array, novo tamanho do array
//Um Array nasce e morre com a sua capacidade
//O que o Array.Resize faz é criar um array novo  com o valor de indices solicitado e copiar os elementos do array antigo 

//Array.Resize(ref array, array.Length * 2);

Console.WriteLine("O que o Array.Resize faz: ");

int[] arrayNovo = new int[array.Length * 2];

//Origem array, destino arrayNovo, a quantidade de elementos que vai ser copiado (tudo ou 2 elementos)
Array.Copy(array, arrayNovo, array.Length);


foreach(int valor11 in arrayNovo){

Console.WriteLine(valor11);
Console.WriteLine(arrayNovo.Length);
}