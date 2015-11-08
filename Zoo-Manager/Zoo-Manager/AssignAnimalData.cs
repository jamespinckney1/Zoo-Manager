using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Manager
{
    class AssignAnimalData
    {


        private List<int> cages;
        private List<Animal> animals;

        public List<int> Cages
        {
            get { return cages; }
            set { cages = value; }
        }

        public List<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }

        public AssignAnimalData(List<int> Cages, List<Animal> Animals)
        {

            this.Cages = Cages;
            this.Animals = Animals;

        }


   }
}
