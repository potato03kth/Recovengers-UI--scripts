using UnityEngine;
using Command;
using Dispatcher;
using UI;

namespace MyGame.UI {
    public class UIInitializer : MonoBehaviour {
        [SerializeField] private GameObject dummy;
        void Start() {
            var dispatcher = new CommandDispatcher(dummy);
            var buttons = FindObjectsByType<UIButtonDefault>(FindObjectsSortMode.None);

            foreach (var btn in buttons) {
                var cmd = dispatcher.GetCommand(btn.GetActionType());
                btn.Initialize(cmd);
            }
        }
    }
}
