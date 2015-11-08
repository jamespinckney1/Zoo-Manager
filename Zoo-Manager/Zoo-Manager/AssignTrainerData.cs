using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Manager
{
    class AssignTrainerData
    {
        

        private List<int> cages;
        private List<Trainer> trainers;

        public List<int> Cages
        {
            get { return cages; }
            set { cages = value; }
        }

        public List<Trainer> Trainers
        {
            get { return trainers; }
            set { trainers = value; }
        }

        public AssignTrainerData(List<int> Cages, List<Trainer> Trainers) {

            this.Cages = Cages;
            this.Trainers = Trainers;        
        
        }
    }
}
