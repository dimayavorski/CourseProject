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
        public DbSet<Human> People { get; set; }
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
            Human h1 = new Human {Age = 18, FirstName = "Яворский", Id = 1, LastName = "Александрович", Name = "Дмитрий", ProjectId = 1};
            Human h2 = new Human { Age = 18, FirstName = "Яворский", Id = 2, LastName = "Александрович", Name = "Дмитрий", ProjectId = 1 };
            List<Project> projects = new List<Project>
            {
                new Project{ Id = 1,Name = "Project1", Profit = 300,Expense = 1200},
                new Project{ Id = 2,Name = "Project2",Profit = 200 , Expense = 800},
                new Project{ Id = 3,Name = "Project3", Profit = 350, Expense = 100},
            };
            db.People.Add(h1);
            db.People.Add(h2);
            db.Projects.AddRange(projects);
            base.Seed(db);
        }
    }
   
}
