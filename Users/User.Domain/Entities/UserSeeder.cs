using User.Domain.Validations;

// Classe isolada criada APENAS para popular a tabela.
namespace User.Domain.Entities
{
    public sealed class UserSeeder : Entity
    {
        // Regras da entidade.
        public UserSeeder(string Name, string Email, string Password)
        {
            ValidateDomain(Name, Email, Password);
        }

        // Modelagem.
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; set; }

        // Validações.
        private void ValidateDomain(string Name, string Email, string Password)
        {
            DomainValidator.Required(Name, "Nome");
            DomainValidator.Required(Email, "Email");
            DomainValidator.Required(Password, "Password");
        }
        
    }
}