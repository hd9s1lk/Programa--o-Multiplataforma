using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_LerXAML
{
    public class Aluno
    {
        public string Numero { get; private set; } = string.Empty;

        public string Nome { get; private set; } = string.Empty;

        public string Curso { get; private set; } = string.Empty;

        //set -> publico porque podemos alterar o valor ao longo do tempo 
        public bool Inscrito { get; set; }

        public Aluno(string numero, string nome, string curso)
        {
            Numero = numero;
            Nome = nome;
            Curso = curso;
            Inscrito = false;

        }
    }
}
