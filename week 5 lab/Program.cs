using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Double price, discountPrice, total = 0, average, count = 0;
            //declare variables
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter the purchase price of the item, press -1 to end: ");
                count = count+1;
                price = Convert.ToDouble(Console.ReadLine());
                if (price != -1)
                {
                    if (price >= 50)
                    {
                        discountPrice = price - (price * .1);
                        total = total + discountPrice;
                    }
                    else
                    {
                        discountPrice = price;
                        total = total + price;
                    }
                    Console.WriteLine();
                    Console.WriteLine("You purchased this item for an original price of " + price.ToString("C") + " and the discout price is " + discountPrice.ToString("C"));
                    Console.WriteLine("Your total sales is: " + total.ToString("C"));
                    average = total / count;
                    Console.WriteLine("your average sale price is: " + average.ToString("C"));
                    Console.WriteLine("Thank you for your transaction!");
                }
            } while (price != -1); //only time you want a ; after a while or if statement
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }
    }
}
