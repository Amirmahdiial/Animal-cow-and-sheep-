using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal__cow_and_sheep_
{
    public class CowParameter<T>
    {
        public HealthParameter<int> TimeToStand { get; set; }
        public HealthParameter<int> TimeToDeal { get; set; }
        public HealthParameter<int> TimeToRelax { get; set; }
        public HealthParameter<int> NumberOfMeal { get; set; }
        public HealthParameter<int> NumberOfMilkProduction { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"CowParameter: Date={Date}, TimeToStand={TimeToStand}, TimeToDeal={TimeToDeal}, TimeToRelax={TimeToRelax}, NumberOfMeal={NumberOfMeal}, NumberOfMilkProduction={NumberOfMilkProduction}";
        }
    }

}
