using Firebase.Storage;
using APH.Maui.Firebase.Core;
using APH.Maui.Firebase.RemoteConfig.Platforms.Android;

namespace APH.Maui.Firebase.RemoteConfig;

public sealed class FirebaseStorageImplementation : DisposableBase, IFirebaseStorage
{
    private readonly FirebaseStorage _instance;

    public FirebaseStorageImplementation()
    {
        _instance = FirebaseStorage.Instance;
    }

    public IStorageReference GetRootReference()
    {
        return _instance.Reference.ToAbstract();
    }

    public IStorageReference GetReferenceFromUrl(string url)
    {
        return _instance.GetReferenceFromUrl(url).ToAbstract();
    }

    public IStorageReference GetReferenceFromPath(string path)
    {
        return _instance.GetReference(path).ToAbstract();
    }
}