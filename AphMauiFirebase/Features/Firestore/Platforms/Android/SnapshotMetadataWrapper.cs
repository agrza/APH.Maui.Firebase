using Firebase.Firestore;

namespace APH.Maui.Firebase.Firestore.Platforms.Android;

public sealed class SnapshotMetadataWrapper : ISnapshotMetadata
{
    public SnapshotMetadataWrapper(SnapshotMetadata metadata)
    {
        HasPendingWrites = metadata.HasPendingWrites;
        IsFromCache = metadata.IsFromCache;
    }

    public bool HasPendingWrites { get; }
    public bool IsFromCache { get; }
}