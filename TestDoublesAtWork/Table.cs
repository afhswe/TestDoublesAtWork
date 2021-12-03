using System;

namespace TableBooking
{
    public class Table
    {
        public int NumberOfPersons { get; private set; }
        public DateTime BookedFor { get; private set; }
        public int TableNumber { get; }
        public string ReservationNumber { get; set; }


        public Table(int tableNumber)
        {
            TableNumber = tableNumber;
        }

        public void ReserveFor(int numberOfPersons, DateTime bookedFor, string reservationNumber)
        {
            NumberOfPersons = numberOfPersons;
            BookedFor = bookedFor;
            ReservationNumber = reservationNumber;
        }
    }
}