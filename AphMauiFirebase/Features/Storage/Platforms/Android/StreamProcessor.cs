using Firebase.Storage;

namespace APH.Maui.Firebase.RemoteConfig.Platforms.Android;

public sealed class StreamProcessor : Java.Lang.Object, StreamDownloadTask.IStreamProcessor
{
    public void DoInBackground(StreamDownloadTask.TaskSnapshot snapshot, Stream stream)
    {
        stream.Close();
    }
}