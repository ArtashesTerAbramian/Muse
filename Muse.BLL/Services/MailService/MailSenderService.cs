using Microsoft.EntityFrameworkCore;
using Muse.BLL.Enums;
using Muse.DAL;

namespace Muse.BLL.Services.MailService;

public class MailSenderService : IMailSenderService
{
    private readonly AppDbContext _db;
    private readonly IMailService _mailService;

    public MailSenderService(AppDbContext db,
        IMailService mailService)
    {
        _db = db;
        _mailService = mailService;
    }

    public async Task SendEmails()
    {
        var mails = await _db.MailQueues
            .Where(x => x.IsSent != true &&
                        x.FailedCount < 5)
            .ToListAsync();

        foreach (var mail in mails)
        {
            if (!string.IsNullOrEmpty(mail.Text) &&
                await _mailService.SendEmailAsync(mail.Contact, mail.Subject, mail.Text))
            {
                mail.IsSent = true;
            }
            else
            {
                mail.FailedCount++;
            }

            await _db.SaveChangesAsync();
        }
    }

    public async Task SendEmail(long mailQueueId)
    {
        var mail = await _db.MailQueues
            .Where(x => x.IsSent != true &&
                        x.FailedCount < 5)
            .FirstOrDefaultAsync(x => x.Id == mailQueueId);

        if (!string.IsNullOrEmpty(mail.Text) &&
            await _mailService.SendEmailAsync(mail.Contact, mail.Subject, mail.Text))
        {
            mail.IsSent = true;
        }
        else
        {
            mail.FailedCount++;
        }

        await _db.SaveChangesAsync();

        if (!mail.IsSent)
        {
            throw new Exception($"Error on sending email to {mail.Contact}");
        }
    }

    public async Task SendNewReservationConfirmed(string email, long reservationId)
    {
        var armMessage =
            "Հարգելի՝ {CustomerName}, Ձեր ամրագրումը {BranchName}-ում , {Date} հաստատված է, <br/> Սիրով կսպասենք՝ {FromTime}.";
        var ruMessage =
            "Уважаемый {CustomerName}, Ваша бронь в {BranchName}, {Date} подтверждена, <br/> Будем ждать в {FromTime}.";
        var enMessage =
            "Dear {CustomerName}, Your reservation in {BranchName},  {Date} is confirmed, <br/> Looking forward to seeing you at {FromTime}.";


        // if (corporation is null)
        // {
            // return;
        // }

        // var message = corporation.LanguageId switch
        // {
            // (long)LanguageEnum.English => enMessage.Replace("{CustomerName}", (reservation?.Customer?.Name ?? "Guest")),
            // (long)LanguageEnum.Russian => ruMessage.Replace("{CustomerName}", (reservation?.Customer?.Name ?? "Гость")),
            // (long)LanguageEnum.Armenian => armMessage.Replace("{CustomerName}",
                // (reservation?.Customer?.Name ?? "Հաճախորդ")),
        // };

        // var title = corporation.LanguageId switch
        // {
            // (long)LanguageEnum.English => "Reserve Confirmation",
            // (long)LanguageEnum.Russian => "Подтверждение брони",
            // (long)LanguageEnum.Armenian => "Ամրագրման հաստատում",
        // };

        // var reservationLocalTime = reservation.FromDate.AddHours(reservation.Branch.TimeZone);

        // message = message
            // .Replace("{BranchName}",
                // reservation.Branch.Translations
                    // .First(x => x.LanguageId == corporation.LanguageId).Name)
            // .Replace("{Date}", reservationLocalTime.ToString("dd.MM.yyyy"))
            // .Replace("{FromTime}", reservationLocalTime.ToString("HH:mm"));

        // await _mailService.SendEmailAsync(email, title, message);
        
    }
}