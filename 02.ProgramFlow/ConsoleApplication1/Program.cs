using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your fruit is:"); 
            var fruitString = Console.ReadLine();
            string fruit = fruitString;
         
            if (fruit == "apple")
            {
                Console.WriteLine("What is your fruit colour?");
                var fruitcolourString = Console.ReadLine();
                string fruitcolour = fruitcolourString;

                if (fruitcolour == "green")
                { 
                    Console.WriteLine("Green apples are my favourite");
                }
                else if (fruitcolour == "red")
                {
                    Console.WriteLine("Snow White likes red apples");
                }

                else
                {
                    Console.WriteLine("I do not know such kinds of apples.");
                }
              
            }

            else if (fruit == "orange")
            {
                    Console.WriteLine("IS your orange sweet or sour?");
                    var fruittasteString = Console.ReadLine();
                    string fruittaste = fruittasteString;

                    if (fruittaste == "sweet")
                    {
                        Console.WriteLine("Sweet oranges are the best");
                    }

                    else if (fruittaste == "sour")
                    {
                        Console.WriteLine("IS your orange big or small?");
                        var fruitsizeString = Console.ReadLine();
                        string fruitsize = fruitsizeString;

                        if (fruitsize == "big")
                        {
                            Console.WriteLine("Congrats!You have a big sour orange!");
                        }
                        else if (fruitsize == "small")
                        {
                            Console.WriteLine("Maybe you have a lime instead of an orange");
                        }
                    
                                        }
                                    /* else if (fruittaste != "sweet" || fruittaste != "sour")
                                   {
                                       Console.WriteLine("Let's start over. Your fruit is: ");
                                       fruitString = Console.ReadLine();
                                       fruit = fruitString;
                                   } */
                                    /*Nu imi place cum se termina programul. Cum fac sa se intoarca la "Your fruit is:" */ /*maybe ceva cu do...while */
                    else
                     {
                        Console.WriteLine("Start all over! Start again the program?");
                     }
            }
            

          else
           { 
              Console.WriteLine(fruit + " is not on our list. I like apples and oranges");
           }
            
              Console.ReadKey();
           }
        }
    }

 