using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_9
{
    public class Departamento
    {
        public string Nome { get; private set; } = string.Empty;

        public int NDocentes { get; private set; }

        //construtor
        public Departamento(string _nome, int _nDocentes) {
            Nome = _nome;
            NDocentes = _nDocentes;
        }
    }
}
