using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    internal class SeatManager
    {
        List<Seat> seats;

        public SeatManager(int numOfSeats)
        {
            seats = new List<Seat>();

            for (int i = 0; i < numOfSeats; i++)
                seats.Add(new Seat());
        }
    }
}
