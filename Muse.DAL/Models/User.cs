namespace Muse.DAL.Models;

public class User : BaseEntity
{
    public User()
    {
        Bookings = new HashSet<Booking>();
    }
    
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public string? ResetPasswordToken { get; set; }
    public required string Phone { get; set; }
    public DateTime? ResetPasswordRequestDate { get; set; }
    public bool EmailIsVerified { get; set; }
    public string? PhotoUrl { get; set; }
    public long DefaultLanguageId { get; set; }
    public Language DefaultLanguage { get; set; }
    public long RoleId { get; set; }
    public Role Role { get; set; }
    public bool BasePasswordIsChanged { get; set; }
    public string? EmailVerificationToken { get; set; }
    public DateTime? EmailVerificationRequestDate { get; set; }
    
    public ICollection<Booking> Bookings { get; set; }

}