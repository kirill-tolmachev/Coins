using TMPro;
using UnityEngine;

namespace Controllers
{
    internal class LabelController<TValue> : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _label;

        protected virtual void Start()
        {
            SetText(default);
        }

        protected void SetText(TValue value) => _label.text = FormatText(value);

        protected virtual string FormatText(TValue value) => value.ToString();

        protected GameStateEntity CreateListener() => Contexts.sharedInstance.gameState.CreateEntity();
    }
}
