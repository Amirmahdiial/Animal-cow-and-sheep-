using Animal__cow_and_sheep_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal__cow_and_sheep_
{
    public class Cow : Animal, IComparable<Cow>, IEnumerable<CowParameter<int>>
    {
        public static int Number { get; set; }
        public List<CowParameter<int>> Parameters { get; set; }

        public override string ToString()
        {
            return $"Cow: BirthDate={BirthDate}, MaxLife={MaxLife}, Environments={Environments}, Number={Number}, Parameters={Parameters}";
        }

        public int CompareTo(Cow other)
        {
            return 0;
        }

        public IEnumerator<CowParameter<int>> GetEnumerator()
        {
            return Parameters.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override float StressFactor()
        {
            return 0.0f;
        }

        public override int Life()
        {
            return 0;
        }

        public override int TimeToDie()
        {
            return 0;
        }

        public override float KillPriority()
        {
            return 0.0f;
        }

        public override int CostPerDay()
        {
            return 0;
        }

        public override int ValuePerDay()
        {
            return 0;
        }
    }

    
}
