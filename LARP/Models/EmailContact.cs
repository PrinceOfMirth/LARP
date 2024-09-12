namespace LARP.Models
{
    public class EmailContact
    {
        public string Email { get; private set; }

        public EmailContact(string email)
        {
            if (IsValidEmail(email))
            {
                Email = email;
            }
            else
            {
                throw new ArgumentException("Invalid email format", nameof(email));
            }
        }

        private static bool IsValidEmail(string email)
        {
            // Simple email validation logic
            return email.Contains('@') && email.Contains('.');
        }

        public override string ToString()
        {
            return Email;
        }
    }
}
