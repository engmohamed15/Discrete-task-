using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace descrite_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end, count, prime=0;

            Console.WriteLine("enter your start number" );
             
            start = int.Parse( Console.ReadLine() );
            Console.WriteLine("enter your end number");
             end = int.Parse(Console.ReadLine());
            for (int num = start; num < end; num++)
            {
                prime = 0;
                if (num > 1)
                {
                    for ( count = 2; count < num; count++)
                    {
                        if (num % count == 0)
                        {
                            prime = 1;
                            break;
                        }
                    }
                    if (prime == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            Console.ReadKey();

            }







        }
    }
