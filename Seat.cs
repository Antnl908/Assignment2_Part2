using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    public class Seat
    {
        class Status
        {
            public bool available;
        }

        Status status;

        public Seat()
        {
            status = new Status();
        }
    }
}
