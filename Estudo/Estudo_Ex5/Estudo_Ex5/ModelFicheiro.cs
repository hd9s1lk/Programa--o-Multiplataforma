using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Ex5
{
    public class ModelFicheiro
    {
        public delegate void MetodosSemParametros();

        public string Texto { get; private set; } = string.Empty;

        public event MetodosSemParametros? EventoFicheiroGuardado;

        public event MetodosSemParametros? EventoFicheiroLido;

        public void GuardarTexto(string fileName,  string texto)
        {
            StreamWriter streamWriter = new StreamWriter(fileName);

            streamWriter.WriteLine(texto);

            streamWriter.Close();

            EventoFicheiroGuardado?.Invoke();
        }

        public void LerFicheiro(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);

            streamReader.Close();

            Texto = textoLido;  

            EventoFicheiroLido?.Invoke();
        }


    }
}
