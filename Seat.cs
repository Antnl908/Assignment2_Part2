using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    public class Seat
    {
        int id;
        int clientId;
        public enum Status { available, occupied }
        public Status status = Status.available;

        public Seat(int id)
        {
            this.id = id;
        }

        public void Book(int clientId)
        {
            this.clientId = clientId;
            CurrentStatus = Status.occupied;
        }

        public Status CurrentStatus
        {
            get { return status; }
            set { status = value; }
        }

        public int Id => id;
        public int ClientId { get => clientId; set => clientId = value; }
        public bool IsAvailable { get => status == Status.available; }
    }
}
