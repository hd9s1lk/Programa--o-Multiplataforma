using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceções_Aula8
{
    //delegate
    public delegate void D(string valor);

    //public -> para inicializar na App
    public class ModelTexto
    {
        //Propriedade para guardar todos os textos inseridos
        public List<string> Lista { get; private set; } = new List<string>(); //só próprio model atualiza o valor (set privado)

        public event D TextoValido;

        public void InserirValidarTexto(string texto)
        {
            //converter texto num número inteiro
            //Caso seja um texto vai gerar uma exceção   //TAMBÉM PODEMOS E DEVEMOS POR A EXCEÇÃO DENTRO DA FUNÇÃO NO MODEL REI
            //int valor = Convert.ToInt32(texto);

            //Inicializar a exceção
            if (texto.Length > 10)
            {
                //mensagem
                //throw new ArgumentOutOfRangeException("O tamanho do texto é incorreto");
                throw new TextoInvalidoException("O tamanho do texto é errado");
            }

            //adicionar à lista
            Lista.Add(texto);


            //invocar o evento
            TextoValido?.Invoke(texto);
        }

    }
}
