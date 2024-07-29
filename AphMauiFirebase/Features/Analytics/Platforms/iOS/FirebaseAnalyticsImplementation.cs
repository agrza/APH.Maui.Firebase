using APH.Maui.Firebase.Core;
using System.Diagnostics;
using APH.Maui.Firebase.Analytics.Platforms.iOS.Extensions;

namespace APH.Maui.Firebase.Analytics;

public sealed class FirebaseAnalyticsImplementation : DisposableBase, IFirebaseAnalytics
{
    public Task<string> GetAppInstanceIdAsync()
    {
        //return Task.FromResult(FirebaseAnalytics.AppInstanceId);
        return Task.FromResult("");
    }


    public void LogEvent(string eventName, IDictionary<string, object> parameters)
    {
        //FirebaseAnalytics.LogEvent(eventName, parameters?.ToNSDictionary());
    }

    public void LogEvent(string eventName, params (string parameterName, object parameterValue)[] parameters)
    {
        //LogEvent(eventName, parameters?.ToDictionary(x => x.parameterName, x => x.parameterValue));
    }

    public void SetUserId(string id)
    {
        //FirebaseAnalytics.SetUserId(id);
    }

    public void SetUserProperty(string name, string value)
    {
        //FirebaseAnalytics.SetUserProperty(value, name);
    }

    public void SetSessionTimoutDuration(TimeSpan duration)
    {
        //FirebaseAnalytics.SetSessionTimeoutInterval(duration.TotalSeconds);
    }

    public void ResetAnalyticsData()
    {
        //FirebaseAnalytics.ResetAnalyticsData();
    }

    public bool IsAnalyticsCollectionEnabled
    {
        //set => FirebaseAnalytics.SetAnalyticsCollectionEnabled(value);
        set => Debug.Write(value);
    }
}
