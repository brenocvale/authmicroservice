using System.Globalization;
using User.Domain.Exceptions;

namespace User.Domain.Validations
{
    public static class DomainValidator
    {
        public static void Required(string value, string field)
        {
            if(string.IsNullOrWhiteSpace(value)){
                throw new DomainException($"É necessário preencher o campo {field}.");
            }
        }

        public static void MinLenght(string value, string field, int minLength)
        {
            if(value == null || value.Length == minLength){
                throw new DomainException($"O campo {field} deve ter no mínimo {minLength} caracteres.");
            }
        }

        public static void MaxLength(string value, string field, int maxLength)
        {
            if (value != null && value.Length > maxLength)
                throw new DomainException($"O campo {field} ultrapassou o limite de {maxLength} caracteres.");
        }

        public static void Email(string value)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new DomainException("Email inválido.");
        }

    }
}
