using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Methods
{

    public class MyClassMatch
    {
        public static (string Message, double Value) MyOperations(double x, double y, char s)
        {
            if (s ==  '1')
            {
                return ("Сумма равна:", x + y); 
            }

            else if (s == '2')
            {
                return ("Разность равна:", x - y);
            }

            else if (s == '3')
            {
                return ("Произведение равно:", x * y);
            }

            else if (s == '4')
            {
                return ($"Частное равно:", x / y);
            }
            else
            {
                return ("Неверный знак", 0);
            }
            
        }
    }
}