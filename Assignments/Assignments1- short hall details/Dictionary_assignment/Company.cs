using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_assignment
{
    internal class Company
    {
        public string CName { get; set; }
        public int NoOfOffers { get; set; }

        public Company(string cName, int noOfOffers)
        {
            this.CName = CName;
            this.NoOfOffers = NoOfOffers;
        }
        public Company()
            {
            }
    }

}
