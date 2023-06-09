using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    internal class Client
    {
        int id;
        SeatManager seatManager;
        bool lucky = false;

        public Client(SeatManager seatManager, int id)
        {
            this.id = id;
            this.seatManager = seatManager;
        }

        public void Run()
        {
            while (seatManager.seatIsAvailable() && !lucky)
                lucky = seatManager.bookFirstAvailable(this);
        }
    }
}
