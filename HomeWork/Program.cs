using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork//second branch
{
    class Program
    {
        static void Main()
        {
            string[] name=new string[3];
            static int GetValidInput(string variableName)
            {
                int number;
                while (true)
                {
                    Console.Write($"{variableName}= ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("empty");
                        continue;
                    }
                    try
                    {
                        number = int.Parse(input, CultureInfo.InvariantCulture);
                        if (number < 2)
                        {
                            Console.WriteLine("too small");
                            continue;
                        }
                        break;//
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("not a number");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("number is too big");//second branch
                    }
                }
                return number;
            }
            int ListSize = GetValidInput("AmountOfStudens in group: ");
            StudentList B121 = new StudentList(ListSize);//-1
            
            for (int i = 0; i < ListSize; i++) 
            {
                Console.Write($"{i+1} First name: ");
                name[0] = Console.ReadLine();
                Console.Write($"{i + 1} Middle name: ");
                name[1] = Console.ReadLine();
                Console.Write($"{i + 1} Last name: ");
                name[2] = Console.ReadLine();
                B121.RenameStudent(i, name[0], name[1], name[2]);
            }
            B121.PrintAll();
            Console.Write($"\ntotal student: " + B121.GetAmountOfStudent());

                Console.Write($"\nRename {B121.GetFullName(1)}");
                Console.Write($"\nNew first name(type nothing if corect): ");
                name[0] = Console.ReadLine();
                Console.Write($"New middle name: ");
                name[1] = Console.ReadLine();
                Console.Write($"New last name: ");
                name[2] = Console.ReadLine();
                B121.RenameStudent(1, name[0], name[1], name[2]);

            B121.PrintAll();
        }
    }
}
