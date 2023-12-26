using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




// Supondo que a classe 'teste' tenha um método 'Somar'
namespace Programa_002.Models
{
    public class Teste
    {
          public void Potencia  (double x, double y )
        { //Math é uma class
            double po =  Math.Pow(x, y);
            ///O Math.round (variavel, numero de casas 4) vai formatar para mostrar apenas 4 digitos.
          Console.WriteLine($"A potencia entre {x} e {y} é:  " + Math.Round(po, 4) );
        }
        public int Somar(int a, int b)
        {
            return a + b;
            
        }

        public void RaizQuadrada(double x){

        double resultadoDaRaiz = Math.Sqrt(x);
        Console.WriteLine(resultadoDaRaiz);
        }
      
    }
}

// Em algum outro lugar do código
