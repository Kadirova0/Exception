namespace Exceptions
{
    using System;

    public class ShortEmailException : Exception
    {
        public ShortEmailException(string message) : base(message)
        {
        }
    }

    public class NotAnEmailAdressException : Exception
    {
        public NotAnEmailAdressException(string message) : base(message)
        {
        }
    }

    public class EmailValidator
    {
        public bool Validate(string email)
        {
            if (email.Length < 10)
            {
                throw new ShortEmailException("Short email address.");
            }

            if (!email.EndsWith("@mail.com"))
            {
                throw new NotAnEmailAdressException("Not an email address.");
            }

            return true;
        }
    }

    public class Program
    {
        public static void Main()
        {
            var emailValidator = new EmailValidator();

            try
            {
                bool isValid = emailValidator.Validate("fatima.qadirova@mail.com");
                Console.WriteLine(isValid);
            }
            catch (ShortEmailException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotAnEmailAdressException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


    
}