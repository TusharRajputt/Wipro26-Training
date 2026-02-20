using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExamles
{
    /// <summary>
    /// Program to Demo about Exception Handling
    /// </summary>
    internal class DivisionEx
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 Numbers   ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine($"Division  {c}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Number is Too Big...");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Division By Zero Impossible...");
            }
            catch(FormatException e)
            {
                Console.WriteLine("String Cannot Be Converted as Integer...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Program from Wipro26");
            }
        }
    }
}
