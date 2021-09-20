using System;

namespace TestDoublesAtWork
{
    public interface ITableRepository
    {
        bool HasFreeTable(int numberOfPersons, DateTime bookingDateAndTime);
        Table GetNextFreeTable(int bookingRequestNumberOfPersons, DateTime bookingRequestBookingDateAndTime);
        void Save(Table freeTable);
    }
}