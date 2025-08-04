using UnityEngine;
using Command;
namespace Command
{
    public class ToggleViewVibeNodeCommand : ICommand
    {
        private GameObject Dummy;

        public ToggleViewVibeNodeCommand(GameObject dummy)
        {
            Dummy = dummy;
        }

        public void Excute()
        {
            // Dummy.DummyCall("OpenSetting");
            DummyCommandBridge.Invoke("ToggleViewVibeNodeCommand");
        }

        public void Undo()
        {
            
        }

    }
}
