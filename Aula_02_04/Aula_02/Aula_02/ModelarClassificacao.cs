using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    public class ModelarClassificacao
    {

        //1. Passo para a criação de eventos 
        //-> criação de um delegate
        //Delegate genérica para métodos que recebam um parametro inteiro e não retornem nada
        public delegate void MetodosComInt(int valor);

        //Armazenar as notas inseridas 
        public List<int> Notas {  get; private set; }

        //2-> criar evento através do delegate
        //usar a palavra event
        //é do tipo delegate 
        public event MetodosComInt NotaInserida;

        public ModelarClassificacao()
        {
            //Inicializar a lista
            Notas = new List<int>();

        }

        //Método
        //Ser responsável por inserir notas 

        public void InserirNota(string nota)
        {
            //Converter para inteiro
            //TPC: trabalhar com double
            //ToDouble
            int notaInt = Convert.ToInt32(nota);
            Notas.Add(notaInt);

            //Lançar um evento para avisar que a nota foi inserida

            //Verificar se existe alguém que vai subscrever o evento 
            if(NotaInserida != null)
            {
                NotaInserida(notaInt);
            }
        }
    }
}
