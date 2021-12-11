using System;
using System.IO;
using System.Text;
using desafio_04;

namespace desafio_04
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Buscar Aluno");
            var aluno=ListaAluno.GetAluno();
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Montando Arquivo");
            sb.AppendLine("Nome;Idade;Nota");
            aluno.ForEach(x => sb.AppendLine($"{x.Nome};{x.Idade};{x.Nota}"));
            var filePath = @"E:\Projetos\Codeless\desafio_05\Arquivo_csv\Aluno.csv";
            Console.WriteLine("Salvando Arquivo");
            File.WriteAllText(filePath, sb.ToString());
            Console.ReadKey();  
         
        }
    }
}