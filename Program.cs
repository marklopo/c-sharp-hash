using System;

namespace hash
{
    class Program
    {
        static string value1() {
            Console.WriteLine("Enter the first value:");
            string value1 = Console.ReadLine();
            int HValue1 = value1.GetHashCode();
            string a = HValue1.ToString();
            
            Console.WriteLine("Your first hash value:");
            Console.WriteLine(a);
            Console.WriteLine("------------------------");
            return a;
        }
        static string value2()
        {
            Console.WriteLine("\nEnter the second value:");
            string value2 = Console.ReadLine();
            int HValue2 = value2.GetHashCode();
            string b = HValue2.ToString();
           
            Console.WriteLine("Your second hash value:");
            Console.WriteLine(b);
            Console.WriteLine("------------------------");
            return b;
        }

        static void Main(string[] args)
        {
           string one = value1();
           string two = value2();
            int c = 0;

            if (!one.Equals(two))
            {
                do
                {
                    c++;
                    if (c < 3)
                    {
                        Console.WriteLine("\nThe hash values are NOT THE SAME");
                      
                        Console.WriteLine("\nRetry number " + c + "");
                        Console.WriteLine(".................................");
                        one = value1();
                        two = value2();
                    }
                    else
                    {
                        Console.WriteLine("\nQuery limit exceeded");
                        Console.WriteLine("\nThe application will close");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }


                }
                while (!one.Equals(two));
                Console.WriteLine("The hash values ​​are THE SAME");
                Console.WriteLine("\nThe application will close");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
               
                Console.WriteLine("The hash values are THE SAME");
                Console.WriteLine("\nThe application will close");
                Console.ReadLine();
                Environment.Exit(0);
            }
            
          

        }


        
           

        }
    }

