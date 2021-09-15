using CommonLib.Classes.Hooks;
using System;
using System.ComponentModel;

namespace CommonLib.Classes.Managers
{
    /// <summary>
    /// KeyboardHook do not work with console applications
    /// </summary>
    public class HookManager : IDisposable
    {
        private KeyboardHook _keyboardhook = new KeyboardHook();
        public PropertyChangedEventHandler KeyPressed;

        public HookManager()
        {
            KeyboardHook.KeyPressed += InternalHook;
        }

        public void StartKeyboardHook()
        {
            _keyboardhook.StartHook();
        }

        public void StopKeyboardHook()
        {
            _keyboardhook.StopHook();
        }

        public string GetKeyboardKey()
        {
            return _keyboardhook.Returnkey();
        }

        private void InternalHook(object sender, PropertyChangedEventArgs e)
        {
            this.KeyPressed?.Invoke(e, null);
        }

        public void Dispose()
        {
            _keyboardhook = null;
            KeyPressed -= InternalHook;
        }
    }
}
