using System;
using Seniors.db;
using System.Linq;

namespace Seniors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista dos funcionários mais antigos, masculino e feminino:");

            using (var db= new employeesContext())
            {
                var masculino= db.Employees.Where(m=> m.Gender=="M").First();
                string sobrenomeM= masculino.LastName.ToUpper();
                string nomeM= masculino.FirstName;
                string generoM= masculino.Gender;
                Console.WriteLine($"{sobrenomeM}, {nomeM}. Gênero: {generoM}");
                  
                var feminino= db.Employees.Where(f=> f.Gender=="F").First();
                string sobrenomeF= feminino.LastName.ToUpper();
                string nomeF= feminino.FirstName;
                string generoF= feminino.Gender;
                Console.WriteLine($"{sobrenomeF}, {nomeF}. Gênero: {generoF}");
            }
        }
    }
}
