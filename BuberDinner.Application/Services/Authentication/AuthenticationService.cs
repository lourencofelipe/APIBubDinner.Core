using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    public AuthenticationResult Register(string firstName, string lastName, string email, string password) 
    {
        //check if user already exists
        if (_userRepository.GetUserByEmail(email) is not null)
            throw new Exception("User with given email already exists.");

        // Create user (unique ID)
        var user = new User() 
        {
            FirstName = firstName, 
            LastName = lastName, 
            Email = email, 
            Password = password
        };

        _userRepository.Add(user);

        // Create Jwt token.
        var token = _jwtTokenGenerator.GenerateToken(user.Id, firstName, lastName);

        return new AuthenticationResult(
            user.Id, 
            firstName, 
            lastName, 
            email, 
            password,
            token);
    }

    public AuthenticationResult Login(string email, string password)
    { 
        // Validate the user exists.
        if(_userRepository.GetUserByEmail(email) is not User user)
            throw new Exception("User with given email does not exists.");

        // Validate the password is correct.
        if(user.Password != password)
            throw new Exception("Invalid password");

        // Create JWT Token.
        var token = _jwtTokenGenerator.GenerateToken(user.Id, user.FirstName, user.LastName);


        return new AuthenticationResult(
            user.Id, 
            user.FirstName, 
            user.LastName, 
            email,
            password,
            token);
    }

}