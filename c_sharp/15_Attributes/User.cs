using System.ComponentModel.DataAnnotations;

[Serializable]
public class User
{
    [Range(1000, 9999, ErrorMessage = "ID must be between 1000 and 9999.")]
    public int Id { get; set; }

    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Login can only contain letters.")]
    public string Login { get; set; }

    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Password can only contain letters.")]
    public string Password { get; set; }

    [MinLength(8, ErrorMessage = "Confirm Password must be at least 8 characters long.")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Confirm Password can only contain letters.")]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    public string ConfirmPassword { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }

    [Length(16,16 ,ErrorMessage = "Invalid credit card format.")]
    public string CreditCard { get; set; }

    [RegularExpression(@"^\+38-0\d{2}-\d{3}-\d{2}-\d{2}$", ErrorMessage = "Invalid phone format. Format: +38-0XX-XXX-XX-XX.")]
    public string Phone { get; set; }
}