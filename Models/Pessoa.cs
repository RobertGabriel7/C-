using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Caminho do arquivo
namespace C_Sharp.Models
{
    //Classe publica que se chama Pessoa
    //Nome de class precisa ser em PascalCase, por exemplo: PessoaFisica
    public class Pessoa
    {
        //prop cria uma propriedade
        
        //Atributo/Propriedade publica com o tipo string e o nome da propriedade é Nome
        //Nome de Atributo/propriedade também precisa ser em PascalCase
        public string Nome { get; set; }

        public int Idade { get; set; }

        //Método no C#
        //Esse Void significa que o método não vai retornar valor algum para ser usado posteriormente. Vai executar, mas não vai retornar valor algum.
        //Método também precisa ser em PascalCase
        public void Apresentar (){

            //Console.WriteLine($"Meu nome é {Nome} " + $"e tenho {Idade} anos."); >>>>>>>>> o + pode ser utilizado como identação
            //\n quebra a linha, semelhante no python
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}