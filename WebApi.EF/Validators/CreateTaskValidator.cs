using FluentValidation;
using WebApi8.FisstApp.Dto.Create;

namespace WebApi8.FisstApp.Validators
{
    public class CreateTaskValidator : AbstractValidator<CreateTodo>
    {
        public CreateTaskValidator()
        {
            RuleFor(t => t.Name).NotNull().NotEmpty();
        }
    }
}
