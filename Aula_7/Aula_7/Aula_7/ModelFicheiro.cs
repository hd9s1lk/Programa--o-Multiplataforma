using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7
{
    public class ModelFicheiro
    {

        //1-criar um delegate 
        public delegate void MetodosSemParametros();

        //propriedade para armazar o texto
        //set -> private

        //No construtor por defeito Texto = string.Empty;
        public string Texto { get; private set; } = string.Empty;

        //2->criar evento através do delegate
        //? -> estamos a dizer que pode ser null
        public event MetodosSemParametros? EventoFicheiroGuardado;

        //outro evento
        public event MetodosSemParametros? EventoFicheiroLido;

        //Método para guardar o texto num ficheiro
        // 2 Parametros -> um como o nome do ficheiro
        //outro com o texto para guardar
        public void GuardarTexto(string fileName, string texto)
        {
            //Stream para guardar um ficheiro em C#
            //Temos de passar o nome do ficheiro 
            StreamWriter streamWriter = new StreamWriter(fileName);
            //guardar o texto todo no ficheiro
            streamWriter.WriteLine(texto);

            //fechar ficheiro
            streamWriter.Close();

            //Lançar um evento a informar que o ficheiro foi guardado
            //if(EventoFicheiroGuardado  != null)
            //{
            //    EventoFicheiroGuardado();
            //}

            //ou
            //? -> verificar se é diferente de null
            //caso seja chamado o Invoke
            EventoFicheiroGuardado?.Invoke();


        }

        public void LerFicheiro(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            //Ler tudo o que está no ficheiro
            string textoLido = streamReader.ReadToEnd();

            //Fechar o ficheiro
            streamReader.Close();

            //atualizar a propriedade Texto
            Texto = textoLido;

            //notificar que o texto foi lido do ficheiro
            EventoFicheiroLido?.Invoke();


        }
        
    }
}
