using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee newemp = new Employee();

            
            string input = null;
            while(input != "3")
            {
                Console.WriteLine("Menu");
                Console.WriteLine("To add a student enter 1");
                Console.WriteLine("To add a teacher enter 2");
                Console.WriteLine("To quit the program enter 3");
                Console.WriteLine("Please enter selection: ");

                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            Console.WriteLine("Adding new doctor.");

                            Console.WriteLine("Enter new doctor name: ");
                            string names = Console.ReadLine();
                            Scheduled.AddDoctor(new Doctor() { NAME = names });
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Adding new teacher.");
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Closing program.");
                            Console.ReadKey();
                            break;
                            }
                            default:
{
                                Console.WriteLine("The input entered was not valid.");
                                //printMenu();
                                break;
                            }
                        }
            /*Employee credential = new Employee();
            Doctor doccy = new Doctor();
            Nurse nurssy = new Nurse();
            Administrator admin = new Administrator();
            Console.WriteLine("Type a letter of your profession: \n [D]octor \n [N]urse \n [A]dministrator");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D:
                    credential.EnterCredintials();
                    doccy.Display();
                    nurssy.Display();
                    break;
                case ConsoleKey.N:
                    credential.EnterCredintials();
                    doccy.Display();
                    nurssy.Display();
                    break;
                case ConsoleKey.A:
                    credential.EnterCredintials();
                    Console.WriteLine("[S]how list of Doctors, Nurses and Administrators or [M]odify the list");
                    string enter = Console.ReadLine();
                    if (enter == "S")
                    {
                        doccy.Display();
                        nurssy.Display();
                        admin.Display();
                    }
                    else if (enter == "M")
                    {
                        Console.WriteLine("[D]octor \n [N]urse \n [A]dministrator");
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D:

                                doccy.Insert();
                                break;
                        }




                    }
                    break;*/


            

            
            
        }
    }
}
