namespace APH.Maui.Firebase.RemoteConfig;

public enum RemoteConfigFetchStatus : long
{
    NoFetchYet,
    Success,
    Failure,
    Throttled
}