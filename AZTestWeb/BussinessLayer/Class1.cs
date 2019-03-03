using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class Class1
    {
        public List<string> logicFizzBuzz()
        {
            List<string> lstfizzbuzz = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    lstfizzbuzz.Add("Fizz Buzz");
                else if (i % 3 == 0)
                    lstfizzbuzz.Add("Fizz");
                else if (i % 5 == 0)
                    lstfizzbuzz.Add("Buzz");
                else 
                    lstfizzbuzz.Add(i.ToString());
                
            }
            return lstfizzbuzz;
        }

    }
}
