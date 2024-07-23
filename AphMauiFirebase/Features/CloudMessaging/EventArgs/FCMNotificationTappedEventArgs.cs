namespace APH.Maui.Firebase.CloudMessaging.EventArgs;

public sealed class FCMNotificationTappedEventArgs
{
    public FCMNotificationTappedEventArgs(FCMNotification notification)
    {
        Notification = notification;
    }

    public FCMNotification Notification { get; }
}