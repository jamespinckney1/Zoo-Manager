using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Manager
{
    class AnimalDetails
    {
        private int height;
        private double weight;
        private DateTime date;
        private int reason;
        private string notes;

        public int Height {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public AnimalDetails(int aHeight,double aWeight,int aReason,DateTime aDate,string aNote) {

            Height = aHeight;
            Weight = aWeight;
            Reason = aReason;
            Date = aDate;
            Notes = aNote;

        }




    }
}
