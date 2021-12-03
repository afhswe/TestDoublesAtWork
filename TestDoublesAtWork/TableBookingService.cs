namespace TableBooking
{
    public class TableBookingService
    {
        private readonly ITableRepository _tableRepository;
        private readonly INotificationService _notificationService;

        public TableBookingService(ITableRepository tableRepository, INotificationService notificationService)
        {
            _tableRepository = tableRepository;
            _notificationService = notificationService;
        }

        public BookingResult BookTable(BookingRequest bookingRequest)
        {
            if (bookingRequest.NumberOfPersons < 2)
            {
                return BookingResult.Fail("Reservations are only taken for at least two persons");
            }

            if (!_tableRepository.HasFreeTable(bookingRequest.NumberOfPersons, bookingRequest.BookingDateAndTime))
            {
                return BookingResult.Fail("Request can not be fulfilled");
            }

            var freeTable = _tableRepository.GetNextFreeTable(bookingRequest.NumberOfPersons,
                bookingRequest.BookingDateAndTime);
            freeTable.ReserveFor(bookingRequest.NumberOfPersons, bookingRequest.BookingDateAndTime, bookingRequest.GenerateReservationNumber());
            _tableRepository.Save(freeTable);

            _notificationService.SendReservationNotification(bookingRequest.CustomerEmail, bookingRequest.GenerateConfirmationText());

            return BookingResult.Succeed(freeTable.TableNumber);
        }
    }
}
