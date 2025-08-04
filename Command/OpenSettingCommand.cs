using UnityEngine;
using Command;
namespace Command
{
    public class OpenSettingCommand : ICommand
    {
        private GameObject Dummy;

        public OpenSettingCommand(GameObject dummy)
        {
            Dummy = dummy;
        }

        public void Excute()
        {
            // Dummy.DummyCall("OpenSetting");
            DummyCommandBridge.Invoke("OpenSetting");
        }

        public void Undo()
        {
            
        }

    }
}
