using UnityEngine;
using System;

public class DummyCommandBridge
{
    public static event Action<string> OnDummyCall;

    public static void Invoke(string name)
    {
        OnDummyCall?.Invoke(name);
    }
}
