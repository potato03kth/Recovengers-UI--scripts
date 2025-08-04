using UnityEngine;
using Command;
using Dispatcher;

namespace Dispatcher
{
    public class CommandDispatcher
    {
        // [Serialized]
        private GameObject Dummy;
        
        public CommandDispatcher(GameObject dummy)
        {
            Dummy = dummy;
        }

        public ICommand GetCommand(ButtonActionType actionType)
        {
            switch (actionType)
            {
                case ButtonActionType.OpenSettings:
                    return new OpenSettingCommand(Dummy);
                case ButtonActionType.ToggleViewCCTVCommand:
                    return new ToggleViewCCTVCommand(Dummy);
                case ButtonActionType.ToggleViewVibeNodeCommand:
                    return new ToggleViewVibeNodeCommand(Dummy);
                case ButtonActionType.ToggleViewFireNodeCommand:
                    return new ToggleViewFireNodeCommand(Dummy);
                default:
                    // Debug.LogError("Unknown command type");
                    return null;
            }
        }
    }
}