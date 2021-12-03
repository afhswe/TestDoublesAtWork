using System;

namespace TableBooking
{
    public class NotificationService : INotificationService
    {
        public NotificationService()
        {
            SmtpServer.Connect();
        }

        public void SendReservationNotification(string customerEmail, string confirmationText)
        {
            throw new NotImplementedException();
        }
    }
}