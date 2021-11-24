using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Employee
    {
        /*private string name;
        private string surname;
        private int PESEL;
        private string username;
        private string password;
        */
        public string name;
        public string surname;
        public int PESEL;
        public string username;
        public string password;

        public Employee(string name, string surname, int PESEL, string username, string password)
        {
            this.name = name;
            this.surname = surname;
            this.PESEL = PESEL;
            this.username = username;
            this.password = password;
        }
        
        public string NAME { get { return name; } set {  name = value; } }
        public string SURNAME { get { return surname; } set {  surname = value;  } }
        public int PESELNUMBER { get { return PESEL; } set {  PESEL = value; } }
        public string USERNAME { get { return username; } set {  username = value;  } }
        public string PASSWORD { get { return password; } set {  password = value; } }

        /*public static void PrintMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("To add a student enter 1");
            Console.WriteLine("To add a teacher enter 2");
            Console.WriteLine("To quit the program enter 3");
            Console.WriteLine("Please enter selection: ");
        }*/

        /*virtual public void Display()
        {
            Console.WriteLine(name + job + speciality + dutySchedule);
            // returns a list of Employees with their names, job duty, speciality and duty schedule
        }
        
        public EnterCredintials(string username, string password)
        {
            Console.WriteLine("Enter Username \n Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Your Password \n Password: ");
            string password = Console.ReadLine();
            
            return username, password;
            // The user has to enter his username and password to login
        }
        */
    }
}
