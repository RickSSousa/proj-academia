using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj_academia.Models
{
    public class Exercicio
    {
        public int ExercicioID { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
    }
}
