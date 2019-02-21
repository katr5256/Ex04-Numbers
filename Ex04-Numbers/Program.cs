using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double width, length, area;
            string widthString, lengthString;
            Console.Write("Indtast rektanglets højde: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Indtast rektanglets bredde:");
            lengthString = Console.ReadLine();
            length = double.Parse(lengthString);
            area = (width * length);
            Console.WriteLine("Arealet af rektanglet er = " + area);
            Console.WriteLine();
            Console.WriteLine("Indlæs talserie og beregn sum, min og max");
            Console.WriteLine("Indtast talserie (Max. 10 tal)");

            int[] inset = new int[10];
            for(int i=0; i<inset.Length; i++)
            {
                inset[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Talserie indtastet: ");

            for(int i=0; i<inset.Length; i++)
            {
                Console.Write(inset[i] + ", ");
                
            }
            Console.WriteLine();
            Console.Write("Sum af talrække: ");
            int talSum = 0; 
            for (int i = 0; i < inset.Length; i++)

            {
                
                talSum = talSum + inset[i]; 
            }

            Console.Write(talSum);

            Console.WriteLine();
            Console.Write("Talseriens minimum: ");
            
            for(int i=0; i<inset.Length; i++)
               
            {
                if (inset[0] < inset[i])
                {
                    inset[0] = inset[0];
                }
                else 
                {
                    inset[0] = inset[i];
                }

            }
            Console.Write(inset[0]);

            Console.WriteLine();
            Console.Write("Talseriens maksimum: ");

            for(int i=0; i<inset.Length; i++)
            {
                if(inset[0]>inset[i])
                {
                    inset[0] = inset[0];
                }
                else
                {
                    inset[0] = inset[i];
                }
            }
            Console.Write(inset[0]);
            Console.ReadKey();





        }
    }
    
}
