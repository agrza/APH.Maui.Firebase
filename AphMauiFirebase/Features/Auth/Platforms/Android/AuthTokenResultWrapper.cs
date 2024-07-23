using Firebase.Auth;
using APH.Maui.Firebase.Auth.Platforms.Android.Extensions;

namespace APH.Maui.Firebase.Auth.Platforms.Android;

public sealed class AuthTokenResultWrapper : IAuthTokenResult
{
    private readonly GetTokenResult _wrapped;

    public AuthTokenResultWrapper(GetTokenResult wrapped)
    {
        _wrapped = wrapped;
    }

    public T? GetClaim<T>(string key)
    {
        return (T?)_wrapped?.Claims[key]?.ToObject(typeof(T));
    }

    public DateTimeOffset AuthDate => DateTimeOffset.FromUnixTimeSeconds(_wrapped.AuthTimestamp);
    public IDictionary<string, object> Claims => _wrapped.Claims.ToDictionary();
    public DateTimeOffset ExpirationDate => DateTimeOffset.FromUnixTimeSeconds(_wrapped.ExpirationTimestamp);
    public DateTimeOffset IssuedAtDate => DateTimeOffset.FromUnixTimeSeconds(_wrapped.IssuedAtTimestamp);
    public string SignInProvider => _wrapped.SignInProvider;
    public string SignInSecondFactor => _wrapped.SignInSecondFactor;
    public string Token => _wrapped.Token;
}