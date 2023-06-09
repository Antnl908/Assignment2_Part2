using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    internal class SeatManager
    {
        List<Seat> seats;
        int bookedSeats;

        Object lockObj = new Object();

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

           

            lock (lockObj)
            {
                if (seat.IsAvailable)
                {
                    seat.Book(client.Id);
                    Thread.Sleep(100);
                    return true;
                }
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

        public void printStatus()
        {
            //throw new NotImplementedException();
            for(int i = 0; i < seats.Count; i++)
            {
                Console.WriteLine($"Seat:{seats[i].Id} is booked by Client: {seats[i].ClientId}");
            }
        }

        public int getNumberBooked()
        {
            throw new NotImplementedException();
        }
    }
}
