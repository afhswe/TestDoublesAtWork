using System;
using FluentAssertions;
using Xunit;

namespace TableBooking.UnitTests
{
    public class TableBookingTest
    {
        [Fact]
        public void BookTable_Foo()
        {
            var sut = new TableBookingService(new TableRepository(new DatabaseConnection()), new NotificationService());
            sut.BookTable(new BookingRequest()
            {
                BookingDateAndTime = DateTime.Parse("2021-12-10 10:10"),
                CustomerName = "Michael Knight",
                NumberOfPersons = 10
            }).Succeeded.Should().Be(true);
        }
    }
}
