using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    public class Context :DbContext
    {
        public DbSet<People> People { get; set; }
        public DbSet<Project> Projects { get; set; }

        public Context() : base("DefaultConnection")
        {
            Database.SetInitializer(new TestDbInitializer());
        }
    }

    public class TestDbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context db)
        {
            List<People> people = new List<People>
            {
                new People {Age = 18, FirstName = "Яворский", Id = 1, LastName = "Александрович", Name = "Дмитрий", ProjectId = 1},
                new People {Age = 18, FirstName = "Рафалович", Id = 2, LastName = "Леонидович", Name = "Степан", ProjectId = 1},
                new People {Age = 18, FirstName = "Галах", Id = 3, LastName = "Константинович", Name = "Евгений", ProjectId = 1},
                new People {Age = 18, FirstName = "Гайшун", Id = 4, LastName = "Олегович", Name = "Дмитрий", ProjectId = 1},

                new People {Age = 18, FirstName = "Яворский", Id = 5, LastName = "Александрович", Name = "Дмитрий", ProjectId = 2},
                new People {Age = 18, FirstName = "Рафалович", Id = 6, LastName = "Леонидович", Name = "Степан", ProjectId = 2},
                new People {Age = 18, FirstName = "Галах", Id = 7, LastName = "Константинович", Name = "Евгений", ProjectId = 2},
                new People {Age = 18, FirstName = "Гайшун", Id = 8, LastName = "Олегович", Name = "Дмитрий", ProjectId = 2},

            };

            List<Project> projects = new List<Project>
            {
                new Project{ Id = 1,Name = "Project1", Profit = 300,Expense = 1200},
                new Project{ Id = 2,Name = "Project2",Profit = 200 , Expense = 800},
                new Project{ Id = 3,Name = "Project3", Profit = 350, Expense = 100},
            };
            db.People.AddRange(people);
            db.Projects.AddRange(projects);
            base.Seed(db);
        }
    }
   
}
