﻿// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Diagnostics;

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

case "a":
case "e":
case "i":
case "o":
case "u":
    
    Console.WriteLine($"A letra digitada foi '{letra}' e é uma vogal.");
    break;

default:
    
    Console.WriteLine($"A letra digitada foi '{letra}' e não é uma vogal, mas sim, uma consoante .");
    break;

}




