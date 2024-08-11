namespace APH.Maui.Firebase.DynamicLinks.EventArgs;

public sealed class DynamicLinkReceivedEventArgs : System.EventArgs
{
    public DynamicLinkReceivedEventArgs(string link)
    {
        Link = link;
    }

    public string Link { get; }
}
