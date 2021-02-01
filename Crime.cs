using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9_CrimesAndCriminals
{
    class Crime
    {
        private DateTime Date;
        private string Location;
        private string Act;

        public Crime(DateTime Date,string Location, string Act)
        {
            
            this.Location = Location;
            this.Act = Act;
            this.Date = Date;
        }
        public string getAct()
        {
            return Act;
        }
        public string getLocation()
        {
            return Location;
        }
    }
}
