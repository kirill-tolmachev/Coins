using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class InputController : MonoBehaviour, IInput
    {
        private Vector2 _currentInput;

        [SerializeField]
        private FixedJoystick _joystick;

        void Start() => _currentInput = Vector2.zero;

        void Update()
        {
            _currentInput = Vector2.zero;
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            if (_joystick != null)
            {
                x += _joystick.Horizontal;
                y += _joystick.Vertical;
            }

            _currentInput = new Vector2(x, y);
        }

        public Vector2 GetInput() => _currentInput;
    }
}