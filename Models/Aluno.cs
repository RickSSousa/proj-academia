using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj_academia.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Tel { get; set; }
        public string Obs { get; set; }
        public int PersonalID { get; set; }
        public Personal personal { get; set; }
    }
}
