namespace Muse.BLL.Services.MailService;

public interface IMailSenderService
{
    Task SendEmails();
    Task SendNewReservationConfirmed(string email, long reservationId);
    Task SendEmail(long mailQueueId);
}