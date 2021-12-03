using System;

namespace TableBooking
{
    public class TableRepository : ITableRepository
    {
        public TableRepository(DatabaseConnection connection)
        {
            connection.Connect();
        }
        public bool HasFreeTable(int numberOfPersons, DateTime bookingDateAndTime)
        {
            throw new NotImplementedException();
        }

        public Table GetNextFreeTable(int bookingRequestNumberOfPersons, DateTime bookingRequestBookingDateAndTime)
        {
            throw new NotImplementedException();
        }

        public void Save(Table freeTable)
        {
            throw new NotImplementedException();
        }
    }
}