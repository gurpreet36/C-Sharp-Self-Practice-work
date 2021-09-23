using FluentValidation.AspNetCore;
namespace usermanagementService.Models
{
    public class UserValidator:AbstractValidator<User> 
    {
        RuleFor(x => x.username).NotNull();
        RuleFor(x => x.Age).InclusiveBetween(18, 60);
    }
}