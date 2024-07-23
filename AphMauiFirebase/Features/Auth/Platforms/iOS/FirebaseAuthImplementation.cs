using APH.Maui.Firebase.Core;

namespace APH.Maui.Firebase.Auth;

// All the code in this file is only included on iOS.
public sealed class FirebaseAuthImplementation : DisposableBase, IFirebaseAuth
{
    public IFirebaseUser CurrentUser => throw new NotImplementedException();

    public IDisposable AddAuthStateListener(Action<IFirebaseAuth> listener)
    {
        throw new NotImplementedException();
    }

    public Task<IFirebaseUser> CreateUserAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<string[]> FetchSignInMethodsAsync(string email)
    {
        throw new NotImplementedException();
    }

    public bool IsSignInWithEmailLink(string link)
    {
        throw new NotImplementedException();
    }

    public Task<IFirebaseUser> LinkWithEmailAndPasswordAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<IFirebaseUser> LinkWithPhoneNumberVerificationCodeAsync(string verificationCode)
    {
        throw new NotImplementedException();
    }

    public Task SendPasswordResetEmailAsync()
    {
        throw new NotImplementedException();
    }

    public Task SendPasswordResetEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task SendSignInLink(string toEmail, ActionCodeSettings actionCodeSettings)
    {
        throw new NotImplementedException();
    }

    public Task<IFirebaseUser> SignInAnonymouslyAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IFirebaseUser> SignInWithAppleAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IFirebaseUser> SignInWithCustomTokenAsync(string token)
    {
        throw new NotImplementedException();
    }

    public Task<IFirebaseUser> SignInWithEmailAndPasswordAsync(string email, string password, bool createsUserAutomatically = true)
    {
        throw new NotImplementedException();
    }

    public Task<IFirebaseUser> SignInWithEmailLinkAsync(string email, string link)
    {
        throw new NotImplementedException();
    }

    public Task<IFirebaseUser> SignInWithPhoneNumberVerificationCodeAsync(string verificationCode)
    {
        throw new NotImplementedException();
    }

    public Task SignOutAsync()
    {
        throw new NotImplementedException();
    }

    public void UseEmulator(string host, int port)
    {
        throw new NotImplementedException();
    }

    public Task VerifyPhoneNumberAsync(string phoneNumber)
    {
        throw new NotImplementedException();
    }
}
