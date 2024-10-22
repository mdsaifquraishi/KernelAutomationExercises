using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.CustomExceptionHandling
{
    public class InvalidPlayerDataException : Exception
    {
        public PlayerData PlayerData { get; }
        public InvalidPlayerDataException() { }

        public InvalidPlayerDataException(String message) :base(message) { }

        public InvalidPlayerDataException(String message, Exception innerException):base(message,innerException) {
        }

        public InvalidPlayerDataException(string message, PlayerData playerData) : base(message)
        {
            PlayerData = playerData;
        }

        // Constructor with a message, TransactionData, and an inner exception
        public InvalidPlayerDataException(string message, PlayerData playerData, Exception innerException)
            : base(message, innerException)
        {
            PlayerData = playerData;
        }




    }
}
