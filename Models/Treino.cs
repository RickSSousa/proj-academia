using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj_academia.Models
{
    public class Treino
    {
        public int TreinoID { get; set; }
        public int AlunoID { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
    }
}
