using System;

namespace TestDoublesAtWork
{
    public class Table
    {
        public int NumberOfPersons { get; private set; }
        public DateTime BookedFor { get; private set; }
        public int TableNumber { get; }

        public Table(int tableNumber)
        {
            TableNumber = tableNumber;
        }

        public void ReserveFor(int numberOfPersons, DateTime bookedFor)
        {
            NumberOfPersons = numberOfPersons;
            BookedFor = bookedFor;
        }
    }
}