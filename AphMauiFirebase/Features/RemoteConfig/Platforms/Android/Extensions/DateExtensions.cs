using Java.Util;

namespace APH.Maui.Firebase.RemoteConfig.Platforms.Android.Extensions;

public static class DateExtensions
{
    public static DateTimeOffset ToDateTimeOffset(this Date date)
    {
        return DateTimeOffset.FromUnixTimeMilliseconds(date.Time);
    }

    public static Date ToJavaDate(this DateTimeOffset @this)
    {
        return new Date(@this.ToUnixTimeMilliseconds());
    }

    public static Date ToJavaDate(this DateTime @this)
    {
        return ToJavaDate((DateTimeOffset) @this);
    }
}