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
                var masculino= db.Employees.Where(m=> m.Gender=="M");
                foreach (var funciM in masculino)
                {
                    string sobrenome= funciM.LastName.ToUpper();
                    Console.WriteLine($"{sobrenome}, {funciM.FirstName}. Gênero: {funciM.Gender}");
                }

                var feminino= db.Employees.Where(f=> f.Gender=="F");
                foreach (var funciF in feminino)
                {
                    string sobrenome= funciF.LastName.ToUpper();
                    Console.WriteLine($"{sobrenome}, {funciF.FirstName}. Gênero: {funciF.Gender}");
                }
            }
        }
    }
}
