using APH.Maui.Firebase.Core.Exceptions;

namespace APH.Maui.Firebase.CloudMessaging
{
    public sealed class FCMException : FirebaseException
    {
        public FCMException(string message)
            : base(message)
        {
        }
    }
}