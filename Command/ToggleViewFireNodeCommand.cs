using UnityEngine;
using Command;
namespace Command
{
    public class ToggleViewFireNodeCommand : ICommand
    {
        private GameObject Dummy;

        public ToggleViewFireNodeCommand(GameObject dummy)
        {
            Dummy = dummy;
        }

        public void Excute()
        {
            // Dummy.DummyCall("OpenSetting");
            DummyCommandBridge.Invoke("ToggleViewFireNodeCommand");
        }

        public void Undo()
        {
            
        }

    }
}
