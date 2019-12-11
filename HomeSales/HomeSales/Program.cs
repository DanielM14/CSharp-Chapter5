using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            int dSales1, dSales2, dSales3, dSales4, dSales5;
            int eSales1, eSales2, eSales3, eSales4, eSales5;
            int fSales1, fSales2, fSales3, fSales4, fSales5;
            int totalFSales = 0;
            int totalESales = 0;
            int totalDSales = 0;

            Console.WriteLine("Enter the 1st sale for Danielle");
            dSales1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd sale for Danielle");
            dSales2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd sale for Danielle");
            dSales3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 4th sale for Danielle");
            dSales4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 5th sale for Danielle");
            dSales5 = Convert.ToInt32(Console.ReadLine());

            totalDSales = dSales1 + dSales2 + dSales3 + dSales4 + dSales5;

            // Now it starts asking for edwards sales

            Console.WriteLine("Enter the 1st sale for Edward");
            eSales1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd sale for Edward");
            eSales2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd sale for Edward");
            eSales3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 4th sale for Edward");
            eSales4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 5th sale for Edward");
            eSales5 = Convert.ToInt32(Console.ReadLine());

            totalESales = eSales1 + eSales2 + eSales3 + eSales4 + eSales5;

            // Now it's going to ask sales for Francis

            Console.WriteLine("Enter the 1st sale for Francis");
            fSales1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd sale for Francis");
            fSales2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd sale for Francis");
            fSales3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 4th sale for Francis");
            fSales4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 5th sale for Francis");
            fSales5 = Convert.ToInt32(Console.ReadLine());

            totalFSales = fSales1 + fSales2 + fSales3 + fSales4 + fSales5;

            // This part tells you who has the highest sales

            if (totalDSales > totalESales && totalDSales > totalFSales)
            {
                Console.WriteLine("The person with the highest sales is Danielle");
            }
            else if (totalESales > totalDSales && totalESales > totalFSales)
            {
                Console.WriteLine("The person with the highest sales is Edward");
            }
            else if (totalFSales > totalDSales && totalFSales > totalESales)
            {
                Console.WriteLine("The person with the highest sales is Francis");
            }
        }
    }
}
