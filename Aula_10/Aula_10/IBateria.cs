using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10
{
    public delegate void MetodosComParametros(int valor);
    public interface IBateria
    {
        //Definição de propriedades, métodos e eventos 

        //Qualquer class que implemente a interface tem de ter as mesmas propeiedades, 
        //métodos e eventos

        /// <summary>
        /// Carga da bateria
        /// </summary>
       
        int Carga {  get; }

        /// <summary>
        /// Carrega a bateria
        /// </summary>
        /// <exception cref="OperacaoInvalidaException"></exception>
        void Carregar();


        /// <summary>
        /// Descarrega a bateria
        /// </summary>
        void Descarregar();


        /// <summary>
        /// evento que notifica quando a carga for atualizada
        /// </summary>
        event MetodosComParametros CargaAtualizada;
    }
}
