using System;
using UnityEngine.InputSystem;

namespace CodeBase.Gameplay.UserInput
{
    public class TouchAction : ITouchAction, IDisposable
    {
        public event Action StartHold;
        public event Action EndHold;

        private readonly Input _input;
        
        public TouchAction(Input input)
        {
            _input = input;
            _input.Map.Hold.started += PressOnStarted;
            _input.Map.Hold.canceled += PressOnCanceled;
            _input.Map.Enable();
        }

        private void PressOnStarted(InputAction.CallbackContext obj)
        {
            StartHold?.Invoke();
        }

        private void PressOnCanceled(InputAction.CallbackContext obj)
        {
            EndHold?.Invoke();
        }

        public void Dispose()
        {
            _input.Map.Hold.started -= PressOnStarted;
            _input.Map.Hold.performed -= PressOnCanceled;
            _input.Map.Disable();
        }
    }
}