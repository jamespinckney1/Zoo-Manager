using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Manager
{
    class Animal
    {

        private string name;
        private DateTime birthDate;
        private int tagNumber;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }


        public int TagNumber
        {
            get { return tagNumber; }
            set { tagNumber = value; }
        }
        
        
        public int calcAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            return age;
        
        }

        public Animal(string aName, DateTime aBirthDate, int aTagNumber) 
        {
            Name = aName;
            BirthDate = aBirthDate;
            TagNumber = aTagNumber;
                  
        
        }



    }
}
