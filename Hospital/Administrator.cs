using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Administrator : Employee
    {
        public Administrator(string name, string surname, int PESEL, string username, string password) : base(string name, string surname, int PESEL, string username, string password) { }
        List<Administrator> Administrators { get; set; }
        /*override public void Display()
        {
            base.Display();
            Doctor doc = new Doctor();
            Nurse nurs = new Nurse();
            Console.WriteLine(doc.Display, doc.nurs);


        }*/


        public bool AddAdmin(Administrator administrator)
        {
            try
            {
                Nurse.Add(administrator);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
