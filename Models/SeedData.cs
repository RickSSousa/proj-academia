using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace proj_academia.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            Context context = app.ApplicationServices.GetRequiredService<Context>();
            context.Database.Migrate();
            if (!context.Alunos.Any())
            {
                context.Alunos.AddRange(new Aluno { Nome = "Ricardo Santos", DataNasc = DateTime.Now, Email = "rick@gmail.com", Instagram = "@rics.exe", Obs = "iniciante", Tel = "(35)99866-8800", PersonalID = 1 });
                context.SaveChanges();
            }
            if (!context.Personais.Any())
            {
                context.Personais.AddRange(new Personal { Nome = "Leo Stronda", Especialidade = "musculação" });
                context.SaveChanges();
            }
            if (!context.Exercicios.Any())
            {
                context.Exercicios.AddRange(new Exercicio { Nome = "Supino", Categoria = "Peito", Descricao = "Levantamendo horizontal de barra não guiada" });
                context.SaveChanges();
            }
            if (!context.Treinos.Any())
            {
                context.Treinos.AddRange(new Treino { Data = DateTime.Now.Date, Hora = System.Convert.ToDateTime(DateTime.Now.Hour), AlunoID = 1 });
                context.SaveChanges();
            }
        }
    }
}
