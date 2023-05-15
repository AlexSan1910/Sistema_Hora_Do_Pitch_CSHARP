using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitch{
    public class Alarme{
        
        // Definindo variaveis


        // propriedade controla o tempo do pitch
        private int _tempo;
        public int Tempo
        {
            get { return _tempo; }
            set { _tempo = value * (1000 * 60); } // calculo para transformar o temppo que o usuario deseja em milisegundos
        }

        // Construtor

        public Alarme()
        {
            this.Tempo = 3; // duração do pitch de 3 minutos
        }

        public Alarme(int tempo)
        {
            this.Tempo = tempo; // contrutor para que o usuario possa definir o tempo que ele deseja pro pitch.
        }
        

        // Definindo Metodo ou Funções

        public void InicarContador()
        {
            Thread.Sleep(this.Tempo); // uma breve pausa na aplicação em milisegundos "250 milisegundos"
            Console.Beep(250, 10); // Reproduz da frequencia e o tempo que a frequencia irá tocar em milisegundos.
        }
    }
}
