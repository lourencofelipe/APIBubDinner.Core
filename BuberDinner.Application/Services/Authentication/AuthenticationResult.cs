namespace BuberDinner.Application.Services.Authentication;

public record AuthenticationResult(
    Guid Id,
    string FirstName, 
    string LastName, 
    string email, 
    string password, 
    string Token);