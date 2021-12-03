namespace TableBooking
{
    public class BookingResult
    {
        public bool Succeeded { get; }
        public int TableNumber { get; private set; }
        public string ErrorMessage { get; private set; }

        private BookingResult(bool succeeded)
        {
            Succeeded = succeeded;
            TableNumber = InvalidTableNumber;
        }

        public const int InvalidTableNumber = -1;

        public static BookingResult Succeed(int tableNumber)
        {
            var result = new BookingResult(true)
            {
                TableNumber = tableNumber
            };
            return result;
        }

        public static BookingResult Fail(string errorMessage)
        {
            var bookingResult = new BookingResult(false)
            {
                ErrorMessage = errorMessage
            };
            return bookingResult;
        }
    }
}