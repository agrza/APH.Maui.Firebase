﻿using Android.Gms.Tasks;
using Exception = Java.Lang.Exception;
using Object = Java.Lang.Object;

namespace APH.Maui.Firebase.Core.Platforms.Android;

public sealed class OnFailureListener : Object, IOnFailureListener
{
    private readonly Action<Exception> _action;

    public OnFailureListener(Action<Exception> action)
    {
        _action = action;
    }

    public void OnFailure(Exception e)
    {
        _action(e);
    }
}
