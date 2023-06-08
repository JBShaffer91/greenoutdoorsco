namespace GreenOutdoorsCo.Api.DTOs
{
  public class UserLoginDto
  {
    private string? username;
    private string? password;

    public string Username 
    {
        get => username ?? throw new ArgumentNullException(nameof(username), "Username cannot be null.");
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Username cannot be null.");
            }

            username = value;
        }
    }

    public string Password 
    {
        get => password ?? throw new ArgumentNullException(nameof(password), "Password cannot be null.");
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Password cannot be null.");
            }

            password = value;
        }
    }
  }
}