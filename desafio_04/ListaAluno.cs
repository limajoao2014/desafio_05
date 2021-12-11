using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_04
{
    public class ListaAluno
    {
        public static List<AlunoModel> GetAluno()
        {
            return new List<AlunoModel>
            {
                new AlunoModel{Nome ="Joao",Idade = 20,Nota =  8.5},
                new AlunoModel {Nome ="Marcos",Idade = 23,Nota =  7.5 },
                new AlunoModel{Nome ="Renan",Idade = 17,Nota =  6.8,},
                new AlunoModel{Nome ="Washington", Idade = 28,Nota =  10}
            };             

        }
        
    }    
}
