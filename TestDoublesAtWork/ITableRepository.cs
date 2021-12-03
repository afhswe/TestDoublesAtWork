using System;

namespace TableBooking
{
    public interface ITableRepository
    {
        bool HasFreeTable(int numberOfPersons, DateTime bookingDateAndTime);
        Table GetNextFreeTable(int bookingRequestNumberOfPersons, DateTime bookingRequestBookingDateAndTime);
        void Save(Table freeTable);
    }
}