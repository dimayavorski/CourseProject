using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
   
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Profit { get; set; }
        public double Expense { get; set; }

        public static double  GetProfitAbility(double profit, double expense)
        {
            return profit / expense * 100;
        }

    }
}
