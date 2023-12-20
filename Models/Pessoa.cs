using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Caminho do arquivo
namespace C_Sharp.Models
{
    //Classe publica que se chama Pessoa
    public class Pessoa
    {
        //prop cria uma propriedade
        
        //Atributo/Propriedade publica com o tipo string e o nome da propriedade é Nome
        public string Nome { get; set; }

        public int Idade { get; set; }

        //Método no C#
        public void Apresentar (){

            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}