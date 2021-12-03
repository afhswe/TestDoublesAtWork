using System;

namespace TableBooking
{
    public class BookingRequest
    {
        public int NumberOfPersons { get; set; }
        public DateTime BookingDateAndTime { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }

        public string GenerateReservationNumber()
        {
            return $"{BookingDateAndTime.ToString("yyyy-MM-dd HH:mm")}-{CustomerName}-{NumberOfPersons}";
        }

        public string GenerateConfirmationText()
        {
            return $"Dear {CustomerName}, your reservation was successfull.{Environment.NewLine}" +
                   $"Your table for {NumberOfPersons} person(s) was booked for {BookingDateAndTime.ToString("yyyy-MM-dd HH:mm")}.{Environment.NewLine} " +
                   $"Your reservation number is {GenerateReservationNumber()}.{Environment.NewLine}" +
                   "Best, your KITT restaurant team";
        }
    }
}