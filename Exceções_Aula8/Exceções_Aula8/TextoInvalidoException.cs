using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceções_Aula8
{
    //Para ser uma excecao tem de derivar da class Excepetion
    public class TextoInvalidoException : Exception
    {
        public TextoInvalidoException(string msg): base(msg) // construtor default da class Exception
        { 
            
        }
    }
}
