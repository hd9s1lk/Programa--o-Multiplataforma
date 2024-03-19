using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_19_03
{
    //Criação de uma classe Figura
    public class Figura
    {
        //Propriedades
        //Get e Set são públicos
        public string Nome { get; set; } = string.Empty; //Evitar o null, começar com uma string vazia;
        public int Altura { get; set; }
        public int Largura { get; set; }

    }
}
