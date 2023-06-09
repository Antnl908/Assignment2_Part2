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
        int bookedSeats;

        public SeatManager(int numOfSeats)
        {
            seats = new List<Seat>();
            bookedSeats = 0;

            for (int i = 0; i < numOfSeats; i++)
                seats.Add(new Seat(i));
        }

        public bool seatIsAvailable()
        {
            foreach (Seat seat in seats)
                if (seat.IsAvailable == true)
                    return true;

            return false;
        }

        public bool bookFirstAvailable(Client client)
        {
            Seat seat = getFirstAvailable();
            if(seat == null)
                return false;

            if (seat.IsAvailable)
            {
                seat.Book(client.Id);
                return true;
            }

            return false;
        }

        private Seat? getFirstAvailable()
        {
            foreach (Seat seat in seats)
                if (seat.IsAvailable == true)
                    return seat;

            return null;
        }

        public string printStatus()
        {
            throw new NotImplementedException();
        }

        public int getNumberBooked()
        {
            throw new NotImplementedException();
        }
    }
}
