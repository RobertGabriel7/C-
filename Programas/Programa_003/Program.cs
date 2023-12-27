using System.Dynamic;
using Programa_003.Models;

//Fazendo uma copia da class padrão
Pessoa Pessoa1 = new Pessoa();

Pessoa1.Nome = "Robert";
Pessoa1.Idade = -1;
Pessoa1.Apresentar();

/* Quando aparece uma caixa na sugestão é um metodo, se for uma chave inglesas é uma propriedade */