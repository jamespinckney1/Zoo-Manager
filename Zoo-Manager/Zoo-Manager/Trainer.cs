using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Manager
{
    class Trainer
    {
        private int trainerID
        private string name;

        public int TrainerID {
            get { return trainerID; }
            set { trainerID = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public Trainer (int aTrainerID , string aName){
        
            TrainerID = aTrainerID;
            Name = aName;
                   
        }


    }
}
