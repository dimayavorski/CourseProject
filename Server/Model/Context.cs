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
        public DbSet<User> Users { get; set; }

        public Context() : base("DefaultConnection")
        {
            Database.SetInitializer(new TestDbInitializer());
        }
    }

    public class TestDbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context db)
        {
            var users = new List<User>
            {
                new User{Id = 1,Name = "Дмитрий",SecondName = "Яворский",MiddleName = "Александрович",Address = "г.Пинск, ул. ИПД20,7303", Password = "rooockman", Email = "dmitry98@gmail.com"}
            };
            List<People> people = new List<People>
            {
                new People {Age = 18, FirstName = "Яворский", Id = 1, LastName = "Александрович", Name = "Дмитрий", ProjectId = 1},
                new People {Age = 18, FirstName = "Рафалович", Id = 2, LastName = "Леонидович", Name = "Степан", ProjectId = 1},
                new People {Age = 18, FirstName = "Галах", Id = 3, LastName = "Константинович", Name = "Евгений", ProjectId = 1},
                new People {Age = 18, FirstName = "Гайшун", Id = 4, LastName = "Олегович", Name = "Дмитрий", ProjectId = 1},

                new People {Age = 18, FirstName = "", Id = 5, LastName = "Александрович", Name = "Антон", ProjectId = 2},
                new People {Age = 22, FirstName = "Рафалович", Id = 6, LastName = "Леонидович", Name = "Кристина", ProjectId = 2},
                new People {Age = 24, FirstName = "Галах", Id = 7, LastName = "Константиновна", Name = "Евгения", ProjectId = 3},
                new People {Age = 19, FirstName = "Гайшун", Id = 8, LastName = "Олегович", Name = "Дмитрий", ProjectId = 4},
                new People {Age = 30, FirstName = "Дуньчик", Id = 9, LastName = "Дмитриевич", Name = "Денис", ProjectId = 3},
                new People {Age = 18, FirstName = "Карпович", Id = 10, LastName = "Олегович", Name = "Олег", ProjectId = 4},

            };

            List<Project> projects = new List<Project>
            {
                new Project{ Id = 1,Name = "Leadersheep", Profit = 300,Expense = 1200},
                new Project{ Id = 2,Name = "Oculus",Profit = 200 , Expense = 800},
                new Project{ Id = 3,Name = "Forward", Profit = 350, Expense = 100},
                new Project{ Id = 4,Name = "SchoolSchedule", Profit = 350, Expense = 400},
            };
            db.People.AddRange(people);
            db.Projects.AddRange(projects);
            db.Users.AddRange(users);
            base.Seed(db);
        }
    }
   
}
