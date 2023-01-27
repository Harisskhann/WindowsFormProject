using System;
namespace assignment
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int Sellingp, costp, profit, loss;

            Console.WriteLine("enter the cost price");
            costp=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the seeling price");
            Sellingp=Convert.ToInt32(Console.ReadLine());

            if (Sellingp > costp)
            {
                profit = (Sellingp - costp);
                Console.WriteLine("enter the profit = " + profit);



            }

            else if (Sellingp< costp)
            {

                loss= (Sellingp - costp);
                Console.WriteLine("enter the loss price = " + loss);




            }
            else
            {

                Console.WriteLine("dont get any loss or profit value");
            }
        }

    }
}
