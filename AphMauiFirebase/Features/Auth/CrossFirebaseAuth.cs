namespace APH.Maui.Firebase.Auth;

public sealed class CrossFirebaseAuth
{
    private static Lazy<IFirebaseAuth> _implementation = new Lazy<IFirebaseAuth>(CreateInstance, LazyThreadSafetyMode.PublicationOnly);

    private static IFirebaseAuth CreateInstance()
    {
#if ANDROID
        return new FirebaseAuthImplementation();
#elif IOS
        return new FirebaseAuthImplementation();
#else
#pragma warning disable IDE0022 // Use expression body for methods
        return null;
#pragma warning restore IDE0022 // Use expression body for methods
#endif
    }

    /// <summary>
    /// Gets if the plugin is supported on the current platform.
    /// </summary>
    public static bool IsSupported => _implementation.Value != null;

    /// <summary>
    /// Current plugin implementation to use
    /// </summary>
    public static IFirebaseAuth Current
    {
        get
        {
            var ret = _implementation.Value;
            if (ret == null)
            {
                throw NotImplementedInReferenceAssembly();
            }
            return ret;
        }
    }

    private static Exception NotImplementedInReferenceAssembly() =>
        new NotImplementedException("This functionality is not implemented in the portable version of this assembly. You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");

    /// <summary>
    /// Dispose of everything 
    /// </summary>
    public static void Dispose()
    {
        if (_implementation != null && _implementation.IsValueCreated)
        {
            _implementation.Value.Dispose();
            _implementation = new Lazy<IFirebaseAuth>(CreateInstance, LazyThreadSafetyMode.PublicationOnly);
        }
    }
}