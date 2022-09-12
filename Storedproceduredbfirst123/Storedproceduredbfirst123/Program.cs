using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storedproceduredbfirst123
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                assign2Entities1 db=new assign2Entities1();
                List<getallemployees_Result> employee = db.getallemployees().ToList();
                foreach (var r in employee)
                {
                    Console.WriteLine($"empid: {r.empid},employeename: {r.empname}");
                }
                //  db.Addemployees(8, "hellen");
                //  db.Addemployees(9, "hazel");
                db.Deleteemployee(3);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }
    }
}
