using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class ErrorTranslationSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        # region Duplicate item  ErrorId = 1

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 1,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 1,
            LanguageId = 1,
            Name = "Duplicate item"
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 2,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 1,
            LanguageId = 2,
            Name = "Дублированное значение"
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 3,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 1,
            LanguageId = 3,
            Name = "Կրկնվող արժեք"
        });

        #endregion

        #region Cannot remove data  ErrorId = 2

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 4,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 2,
            LanguageId = 1,
            Name = "Cannot remove data with reference"
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 5,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 2,
            LanguageId = 2,
            Name = "Нельзя удалить значение со ссылкой"
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 6,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 2,
            LanguageId = 3,
            Name = "չի կարելի ջնջել արժեքը հղումով"
        });

        #endregion

        #region TheGivenValueIsUsed ErrorId = 3

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 7,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 3,
            LanguageId = 1,
            Name = "The given value is used"
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 8,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 3,
            LanguageId = 2,
            Name = "Данное значение используется"
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 9,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 3,
            LanguageId = 3,
            Name = "Տվյալ արժեքը օգտագործվում է"
        });

        #endregion

        #region GivenEmailAlreadyUsed ErrorId = 4

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 10,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 4,
            LanguageId = 1,
            Name = "The specified email address is already used!"
        });

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 11,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 4,
            LanguageId = 2,
            Name = "Указанный электронный адрес уже занят!"
        });

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 12,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 4,
            LanguageId = 3,
            Name = "Նշված էլ. հասցեն արդեն զբաղված է:"
        });

        #endregion

        #region EmailNotVerified ErrorId = 5

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 13,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 5,
            LanguageId = 1,
            Name = "Email is not verified!"
        });

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 14,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 5,
            LanguageId = 2,
            Name = "Адрес эл. почты не подтвержден!"
        });

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 15,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 5,
            LanguageId = 3,
            Name = "Էլ. հասցեն հաստատված չէ:"
        });

        #endregion

        #region CurrentPasswordIsIncorrect ErrorId = 6

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 16,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 6,
            LanguageId = 1,
            Name = "Your current password is incorrect."
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 17,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 6,
            LanguageId = 2,
            Name = "Ваш текущий пароль неправильный."
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 18,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 6,
            LanguageId = 3,
            Name = "Ձեր ընթացիկ գաղտնաբառը սխալ է."
        });

        #endregion

        #region EmailVerificationLinkExpired ErrorId = 7

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 19,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 7,
            LanguageId = 1,
            Name =
                "Oops! Link has expired.\nWe'll send a fresh verification email to your inbox, and you can click the link in that one to confirm your account."
        });

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 20,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 7,
            LanguageId = 2,
            Name =
                "Упс! Срок действия ссылки истек.\nМы отправим новое письмо с подтверждением на ваш почтовый ящик, и вы сможете щелкнуть ссылку в нем, чтобы подтвердить свою учетную запись."
        });

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 21,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 7,
            LanguageId = 3,
            Name =
                "Հղումը ժամկետանց է:\nՄենք նոր հաստատող նամակ կուղարկենք Ձեր նշած էլեկտրոնային փոստի հասցեյինց, որի միջոցով կկարողանաք հաստատել Ձեր հաշիվը:"
        });

        #endregion

        #region PasswordVerificationLinkExpired ErrorId = 8

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 22,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 8,
            LanguageId = 1,
            Name =
                "Oops! Link expired.\nPlease click the \"Forgot password\" button and we will send a new email to the email address you provided, through which you will be able to change your password."
        });

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 23,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 8,
            LanguageId = 2,
            Name =
                "Упс! Срок действия ссылки истек.\n Нажмите кнопку «Забыли пароль», и мы отправим на указанный вами адрес электронной почты новое письмо, с помощью которого вы сможете изменить свой пароль."
        });

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 24,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 8,
            LanguageId = 3,
            Name =
                "Հղումը ժամկետանց է:\nԽնդրում ենք սեղմել «Մոռացել եք գաղտնաբառը» կոճակը և մենք նոր նամակ կուղարկենք Ձեր նշած էլեկտրոնային փոստի հասցեյինց, որի միջոցով կկարողանաք փոխել Ձեր գաղտնաբառը:"
        });

        #endregion

        #region GuestMinQtyNotEmpty ErrorId = 9

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 25,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 9,
            LanguageId = 1,
            Name = "The old password cannot be reused."
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 26,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 9,
            LanguageId = 2,
            Name = "Старый пароль нельзя заново использовать."
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 27,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 9,
            LanguageId = 3,
            Name = "Հին գաղտնաբառը չի կարելի կրկին օգտագործել:"
        });

        #endregion

        #region Oops ErrorId = 10

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 28,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 10,
            LanguageId = 1,
            Name = "Oops! Something went wrong"
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 29,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 10,
            LanguageId = 2,
            Name = "Упс! Что-то пошло не так"
        });
        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 30,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 10,
            LanguageId = 3,
            Name = "Ինչ որ բան այնպես չգնաց"
        });

        #endregion

        #region AccessDenied ErrorId = 11

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 31,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 11,
            LanguageId = 1,
            Name = "Access Denied"
        });

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 32,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 11,
            LanguageId = 2,
            Name = "Доступ запрещен"
        });

        modelBuilder.Entity<ErrorTranslation>().HasData(new ErrorTranslation
        {
            Id = 33,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            ErrorId = 11,
            LanguageId = 3,
            Name = "Հասանելիության սահմանափակում"
        });

        #endregion
    }
}