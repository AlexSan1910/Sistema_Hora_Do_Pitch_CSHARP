using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitch;

namespace HoraPitch{
    public class Program{
        static void Main(string[] args){
            
            // Criando objeto e instanciando ele

            Alarme alarme1 = new Alarme();
            string resposta = "S";

            while(resposta != "N"){ // criando condição

                Console.Clear(); // utilizado para limpar a tela sempre quando começar a condição while novamente.
                Console.Write("Digite a quantidade de tempo para o seu pitch: ");
                alarme1.Tempo = Convert.ToInt32(Console.ReadLine());
                alarme1.InicarContador();
                Console.Write("Digite S para o proximo contadore N para encerrar o programa: ");
                resposta = Console.ReadLine().ToUpper();
            }

        }
    }
}

