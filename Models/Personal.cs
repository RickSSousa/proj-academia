using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj_academia.Models
{
    public class Personal
    {
        public int PersonalID { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public ICollection<Aluno> alunos { get; set; }
    }
}
