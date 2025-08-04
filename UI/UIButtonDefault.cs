using Command;
using Dispatcher;
using UnityEngine;
using UnityEngine.UI;
namespace UI
{
    [RequireComponent(typeof(Button))]
    public class UIButtonDefault : MonoBehaviour
    {
        [SerializeField] private ButtonActionType actionType;
        private ICommand command;

        public void Initialize(ICommand cmd)
        {
            command = cmd;
            var btn = GetComponent<Button>();
            btn.onClick.AddListener(() => cmd.Excute());
        }

        public ButtonActionType GetActionType()
        {
            return actionType;
        }
    }
}