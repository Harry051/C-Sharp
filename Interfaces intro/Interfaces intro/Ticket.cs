using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_intro
{
    internal class Ticket : IEquatable<Ticket>
    {
        // Property to store seat number
        public int SeatNumber { get; set; }
        
        // A simple constructor
        public Ticket(int seatNumber)
        {
            this.SeatNumber = seatNumber;
        }

        public bool Equals(Ticket other)
        {
            return this.SeatNumber == other.SeatNumber;
        }
    }
}
