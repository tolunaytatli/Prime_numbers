using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    class Program
    {

        static void Main(string[] args)
        {

            //Console.WriteLine("Please Enter a Number");
            //double number = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Your Number = " + number);
            UntilPrintPrime();
            Console.ReadLine();
            
        }

        static int IsitPrime() 
        
        {
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            if (number == 2)
            {
                Console.Write("Number is Prime!! ");
               
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number%i==0)
                    {
                        Console.WriteLine("Number is NOT Prime!");
                        x = 1;
                        break;
                    }
                   

                }
                if (x == 0)
                {
                    Console.WriteLine("Prime!!!");
                }
            }

                

            
            
            return number;
        
        }
        
        static int UntilPrintPrime() 
        {
            Console.Write("Tolunay Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            if (number<2)
            {
                Console.WriteLine("Enter a bigger number");
            }
            else if (number==2)
            {
                Console.WriteLine(number);
            }
            else
            {
                for (int j = 3; j < number; j++)
                {
                    for (int i = 2; i < j; i++)
                    {
                    flag =0;
                        if (j % i == 0)
                        {
                            flag = 1;
                            break; 
                        }
                        
                    }
                    if (flag==0)
                    {
                        
                        Console.WriteLine(j);
                    }
                }
                
            }


            return number;
        }    
        
        

        
       
                    
                              
        
    }
}
