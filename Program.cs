using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignmemts3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string to integer-----------------ps1(1)
            /* string mystring;
             int result;
             Console.WriteLine("Enter the string :");
             mystring = Console.ReadLine();
            if(int.TryParse(mystring, out result))
             {
                 Console.WriteLine("converted integer is \t"+result);
             }
             else
             {
                 Console.WriteLine("invalid converstion");
             }
         }
*/
            //string to double-------------------------ps1(2


            /*string StringValues;
            double MyInt;
            StringValues = Console.ReadLine();
            try
            {
                MyInt = Convert.ToDouble(StringValues);
                Console.WriteLine(" Conversion successful. Double value: " + MyInt);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("!Conversion failed. Invalid input format"+ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("!Conversion failed. Value is too large"+ex.Message);
            }
            finally
            {
                Console.WriteLine("! invalid");
            }*/



            //String to decimal --------ps1(3)

            string MyDeciaml;
            decimal MyValue;
            MyDeciaml=Console.ReadLine();
            try
            {
                MyValue=decimal.Parse(MyDeciaml);
                Console.WriteLine("Conversion successful. Decimal value: " + MyDeciaml);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(" Conversion failed. Invalid input format."+ ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Conversion failed. Value is too large or too small for a decimal."+ ex.Message);
            }
            Console.ReadKey();
            /*finally
            {
                Console.WriteLine("!invalid");
            }*/
        }
       
}
    }

