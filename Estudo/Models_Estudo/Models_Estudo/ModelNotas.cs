using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Estudo
{
    public class ModelNotas
    {
        public delegate void MetodosComInt(int valor);

        public List<int> Notas {  get; private set; }

        public event MetodosComInt NotaInserida;

        public ModelNotas()
        {
            Notas = new List<int>();
        }

        public void InserirNota(string valor)
        {
            int notaInt = Convert.ToInt32(valor);
            Notas.Add(notaInt);

            if (NotaInserida != null)
            {
                NotaInserida(notaInt);
            }
        }
    }
}
