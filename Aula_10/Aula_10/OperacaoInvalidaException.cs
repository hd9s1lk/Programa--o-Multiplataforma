using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10
{
    public class OperacaoInvalidaException : Exception
    {
        public OperacaoInvalidaException(string msg) : base(msg) { }
    }
}
