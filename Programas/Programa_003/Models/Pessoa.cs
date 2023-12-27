using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa_003.Models
{
    public class Pessoa
    {
        /* Campo no C# */

  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
        /* So pode acessar o private dentro da class pessoa, não é acessisivel externamente  */
        /* Isso se chama encapsulamento */
        private string _nome; /* O valor da variavel Nome será armazenado aqui */
        
        
        /* Propridade no C#: prop */
        /* Quando a variavel recebe um valor, o get entra em ação  */
        /* Nesse caso, antes mesmo da propriedade receber o valor, ela vai ser verificada para não receber qualquer valor */
        /* public quer dizer que qualquer um pode acessar  */
        public string Nome { 
                        /* get vai retorno o valor para _nome. em Maiusculo */

                        /* Body Expressions: get <= _nome.ToUpper(); para linha simples  */
           get { return _nome.ToUpper();} 
        
            set { if (value == " ")
                        {
                            /* Exeção vai parar o codigo  - throw significa jogar para fora  */
            throw new ArgumentException("O nome não pode estar vazio");
                                       /* O código vai parar no throw new ArgumentException. */             } 

                                       /* Se for digitado algum nome, _nome vai receber o value digitado */
                            _nome = value;
            } 
        }

   
   
   
   
   
   
   
   
   
   
   
   
   
   
        private int _idade;
   
            /* Set atribui o valor e o Get pega/obter o valor */
        public int Idade { 



                                    get {

                                        return _idade;


                                    }
        


                                    set {

                                        if( value < 0 ){
                                            throw new ArgumentException("Precisa adicionar algum valor para idade");
                                        }

                                    _idade = value;

                                    }
                                    
                                

                                
                                }

        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos.");
        }
   
   
   
   
   
   
   



   
   
   
   
   
   
    }
        
}