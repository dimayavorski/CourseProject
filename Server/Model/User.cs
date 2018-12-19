using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
     public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
