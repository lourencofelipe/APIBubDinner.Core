
namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string firstName, string lastName, string email, string password) 
    {
        return new AuthenticationResult(
            Guid.NewGuid(), 
            "firstName", 
            "lastName", 
            email, 
            password);
    }

    public AuthenticationResult Register(string email, string password)
    { 
         return new AuthenticationResult(
            user.Id, 
            firstName, 
            lastName, 
            email, 
            password);
    }

}