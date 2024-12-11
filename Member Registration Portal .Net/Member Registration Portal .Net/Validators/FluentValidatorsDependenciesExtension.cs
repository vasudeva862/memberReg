using FluentValidation;

namespace Member_Registration_Portal_.Net.Validators
{
    public static class FluentValidatorsDependenciesExtension
    {
        public static void ConfigureFluentValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<SignUpRequestValidator>();
        }
    }
}
