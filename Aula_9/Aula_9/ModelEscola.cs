using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_9
{
    //Delegate -> sem parametros
    public delegate void MetodosSemParametros();

    //Para inicializar na App tem de ser publico
    public class ModelEscola : IEnumerable
    {
        public string Nome { get; private set; } = string.Empty;

        //Lista de Departamentos
        public List<Departamento> Departamentos { get; private set; }

        public event MetodosSemParametros DadosCarregados;

        public ModelEscola()
        {
            //Inicializar a lista como vazia
            Departamentos = new List<Departamento>(); //do tipo departamentos, ou seja, guarda o nome e o Ndocentes


        }

        public void CarregarDados()
        {
            //Vão ser estáticos

            Nome = "ECT";
            Departamentos.Add(new Departamento("Engenharias", 30));
            Departamentos.Add(new Departamento("Matemática", 20));
            Departamentos.Add(new Departamento("Chocas", 176));

            //Precisamos de um evento para informar que os dados foram carregados
            if(DadosCarregados != null)
            {
                //Lançar / Invocar o evento
                DadosCarregados();
            }
            
        }

        public Departamento ObterDepartamentoByIndex(int index)
        {
            //através do indice retornamos o departamento
            return Departamentos[index];


        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Departamentos)
            {
                //yield vai retornar cada elemento da lista na ordem que aparece
                yield return item;
            }
        }
    }

 
}
