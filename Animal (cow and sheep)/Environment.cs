using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal__cow_and_sheep_
{
    public class Environment
    {
        public HealthParameter<int> TDS { get; set; }
        public HealthParameter<int> Temp { get; set; }
        public HealthParameter<int> Density { get; set; }
        public HealthParameter<int> db { get; set; }
        public HealthParameter<int> AQI { get; set; }
        public HealthParameter<int> OX { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"Environment: Date={Date}, TDS={TDS}, Temp={Temp}, Density={Density}, db={db}, AQI={AQI}, OX={OX}";
        }
    }
}
