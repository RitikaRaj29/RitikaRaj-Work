using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortHallDetails
{

    class Hall : IComparable<Hall>
    {

        public string name { get; set; }
        public long mobileNo { get; set; }
        public string ownerName { get; set; }
        public double costPerDay { get; set; }

        public Hall(string name, long mobileNo, string ownerName, double costPerDay)
        {
            this.name = name;
            this.mobileNo = mobileNo;
            this.ownerName = ownerName;
            this.costPerDay = costPerDay;
        }

        public Hall()
        {
        }

        public int CompareTo(Hall other)
        {
            if (this.costPerDay > other.costPerDay)
            {
                return 1;

            }
            else if (this.costPerDay < other.costPerDay)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }


        internal void Displayh(List<Hall> h)
        {
            Console.WriteLine("Hall Name " + "   Mobile Number " + "   Owner Name " + "   Cost Per Day");
            for (int i = 0; i < h.Count; i++)
            {
                Console.WriteLine(string.Format("{0,-20} {1,-15} {2,-15} {3,-10}", h[i].name, h[i].mobileNo, h[i].ownerName, h[i].costPerDay));
                Console.WriteLine();

            }
        }
    }
}
    
    

