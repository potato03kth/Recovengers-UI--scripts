using UnityEngine;

public class DummyCommandReceiver : MonoBehaviour
{
    private void OnEnable()
    {
        DummyCommandBridge.OnDummyCall += DummyCall;
    }

    // Update is called once per frame
    private void OnDisable()
    {
        DummyCommandBridge.OnDummyCall -= DummyCall;
    }

    private void DummyCall(string name)
    {
        Debug.Log($"Dummy called, by {name}");
    }
}
