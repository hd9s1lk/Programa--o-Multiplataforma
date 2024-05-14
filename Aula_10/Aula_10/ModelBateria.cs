using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10
{

    public class ModelBateria : IBateria
    {
        public int Carga {  get; private set; }

        public event MetodosComParametros CargaAtualizada;

        public void Carregar()
        {
            //Aumenta a carga em 10%
            if(Carga == 100)
            {
                throw new OperacaoInvalidaException("Batria totalmente carregada");
            }
            Carga += 10;

            //Notificar que a carga foi alterada
            if(CargaAtualizada != null)
            {
                CargaAtualizada(Carga);
            }
            
        }

        public void Descarregar()
        {
            if(Carga == 0)
            {
                throw new OperacaoInvalidaException("Bateria totalmente descarregada");
            }

            Carga -= 10;

            if (CargaAtualizada != null)
            {
                CargaAtualizada(Carga);
            }

            
        }
    }
}
