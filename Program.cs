using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY04_Assignment04_PS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string User, Password;
            int chance = 3;
            int chancegain = 0;
            while (chancegain < chance)
            {
                Console.WriteLine("Enter User Name");
                User = Console.ReadLine();
                Console.WriteLine("Enter Password");
                Password = Console.ReadLine();
                if (User == "john" && Password == "pass123")
                {
                    Console.WriteLine("Login SuccessFully");
                    return;
                }
                else
                {
                    if (User == "john")
                    {
                        Console.WriteLine("Invalid Password");
                    }
                    else
                    {
                        Console.WriteLine("Invalid UserName");
                    }
                }
                
                chancegain += 1;
            }
            
            Console.WriteLine("Login Failed");
            Console.ReadKey();
        }
        
    }
}
