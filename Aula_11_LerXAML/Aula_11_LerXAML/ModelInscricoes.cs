using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Aula_11_LerXAML
{

    public delegate void MetodosSemParametros();
    public class ModelInscricoes
    {
        //Propriedades para guardar a lista dos Alunos
        //Lista de alunos
        //Associado uma chave -> vai ser o numero
        public Dictionary<string,Aluno> Alunos { get; set; }

        public event MetodosSemParametros AlunosChanged;

        public ModelInscricoes() {
            Alunos = new Dictionary<string,Aluno>();
        }    

        public void LerTxt(string fileName)
        {
            //Limpar a lista antes do lermos o ficheiro
            Alunos.Clear();

            //Stream de leitura
            StreamReader sr = new StreamReader(fileName);

            while (!sr.EndOfStream)
            {
                //Cada linha contém um aluno;
                string line = sr.ReadLine();

                //Separar as propriedades do Aluno
                string[] dadosAluno = line.Split(";");

                //Criar um Aluno com os dados
                Aluno aluno1 = new Aluno(dadosAluno[0], dadosAluno[1], dadosAluno[2]);

                if (dadosAluno[3] == "Inscrito")
                {
                    aluno1.Inscrito = true;
                }
                //else -> o default do construtor é false;

                //Adicionar à lista dos Alunos
                Alunos.Add(aluno1.Numero, aluno1);
            }

            sr.Close();
            
            //Lançar em evento a informar que os dados foram lidos
            if(AlunosChanged != null)
            {
                AlunosChanged();
            }


        }

        public void GuardarXML(string fileName)
        {
            if(Alunos.Count == 0)
            {
                return;
            }

            XDocument doc = new XDocument(
                new XDeclaration("1.0", Encoding.UTF8.ToString(), null),
                new XComment("Listagem de Alunos"),
                new XElement("Alunos", new XElement("Inscritos"), new XElement("NaoInscritos")));
            //Criar um doc XML em memória 
            //Guardar esse doc no ficheiro

            foreach(Aluno al in Alunos.Values)
            {
                //Para cada aluno, ter um novo elemento 
                XElement xAluno = new XElement("Aluno",
                    new XAttribute("Numero", al.Numero),
                    new XAttribute("Nome", al.Nome),
                    new XElement("Curso", al.Curso)
                    );

                if (al.Inscrito)
                {
                    doc.Element("Alunos").Element("Inscritos").Add(xAluno);
                } else
                {
                    doc.Element("Alunos").Element("NaoInscritos").Add(xAluno);
                }

                doc.Save(fileName);
            }

        }
        public void SaveJson(string fileName)
        {
            Object jsonData = new
            {
                Alunos = new
                {
                    Inscritos = Alunos.Values
                    .Where(x => x.Inscrito) //filtrar por alunos inscritos
                    .Select(S => new { Numero = S.Numero, Nome = S.Nome, Curso = S.Curso }), //selecionar os valores


                    NInscritos = Alunos.Values
                    .Where(x => !x.Inscrito) //filtrar por alunos inscritos
                    .Select(S => new { Numero = S.Numero, Nome = S.Nome, Curso = S.Curso }), //selecionar os valores

                }
            };
            string jsonString = JsonSerializer.Serialize(jsonData); 

            File.WriteAllText(fileName, jsonString);
        }
    }


}
