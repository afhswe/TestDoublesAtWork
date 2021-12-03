namespace TableBooking
{
    public interface INotificationService
    {
        void SendReservationNotification(string customerEmail, string confirmationText);
    }
}