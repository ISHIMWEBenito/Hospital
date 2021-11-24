using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Scheduled : Employee
    {
        public Scheduled(string name, string surname, int PESEL, string username, string password) : base(string name, string surname, int PESEL, string username, string password) { }
        
        List<Doctor> Doctors { get; set; }
        List<Nurse> Nurses { get; set; }
        
        public bool AddDoctor (Doctor doctor)
        {
            try
            {
                this.Doctors.Add(Doctor);
            }
            catch
            {
                return false;
            }
        }
        public bool AddNurse(Nurse nurse)
        {
            try
            {
                Nurse.Add(nurse);
                return true;

            }
            catch
            {
                return false;
            }
        }
       

        /*override public void Display()
        {
            base.Display();
            Console.WriteLine(name + job + speciality + dutySchedule);
        }

        List<Employee> schedule;
        public show()
        {
            schedule = new List<Employee>();
        }
        public void Add*/

    }
    class Doctor : Scheduled
    {
        Nurse nully = new Nurse();
        private int PWZ;
        // private string[] speciality = new string[] { "Cardiologist", "Urologist", "Neurologist", "Laryngologist" };
        public Doctor(int PWZ, string name, string surname, int PESEL, string username, string password) : base(string name, string surname, int PESEL, string username, string password)
        {
            this.PWZ = PWZ;
           

        }
        public int pwz { get { return PWZ; } }
        /*public string[] SPECIALITY
        {
            get
            {
                return speciality;
            }
            set
            {
                speciality = value;
            }
        
        public override void Display()
        {
            base.Display();
            Console.WriteLine(name + job + speciality + dutySchedule);
        }
        public Insert(int PWZ, string[] speciality, string name, string surname, int PESEL)
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Surname");
            surname = Console.ReadLine();
            Console.WriteLine("Choose speciality: [C]ardiologist, [U]rologist, [N]eurologist, [L]aryngologist");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.C:
                    speciality = speciality[0];
                    break;
                case ConsoleKey.U:
                    speciality = speciality[1];
                    break;
                case ConsoleKey.N:
                    speciality = speciality[2];
                    break;
                case ConsoleKey.L:
                    speciality = speciality[3];
                    break;



            }
            Console.WriteLine("Enter PESEL");
            PESEL = Console.ReadLine();
            Console.WriteLine("Enter PWZ number");
            PWZ = Console.ReadLine();
        */
            



        }
        

    }
    class Cardiologist : Doctor
    {
    readonly String speciality = "Cardiologist";



    }
    class Urologist : Doctor
    {
    readonly string speciality = "Urologist";

    }
    class Neurologist : Doctor
    {
    readonly string speciality = "Neurologist";

    }
    class Laryngologist : Doctor
    {
    readonly string speciality = "Laryngologist";

    }
        
    class Nurse : Scheduled
    {
        public Nurse(string name, string surname, int PESEL, string username, string password) : base(string name, string surname, int PESEL, string username, string password){ }
        /*public override void Display()
        {
            base.Display();
            Doctor docy = new Doctor();
            Console.WriteLine(name + job + speciality + dutySchedule);
        }*/
        

    }
        
            
    
}
