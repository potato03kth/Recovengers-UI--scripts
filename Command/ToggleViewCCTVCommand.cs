using UnityEngine;
using Command;
namespace Command
{
    public class ToggleViewCCTVCommand : ICommand
    {
        private GameObject Dummy;

        public ToggleViewCCTVCommand(GameObject dummy)
        {
            Dummy = dummy;
        }

        public void Excute()
        {
            // Dummy.DummyCall("OpenSetting");
            DummyCommandBridge.Invoke("ToggleViewCCTVCommand");
        }

        public void Undo()
        {
            
        }

    }
}
