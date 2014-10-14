using System.Diagnostics;

namespace MediatorLib
{
    public class Keyboard
    {
        private ComputerSystem _computerSystem;

        public Keyboard(ComputerSystem computerSystem)
        {
            _computerSystem = computerSystem;
            _computerSystem.RegisterKeyboard(this);
            Debug.WriteLine("Keyboard is instantiated");
        }

        public void Enabled()
        {
            Debug.WriteLine("Keyboard enabled");
        }

        public void Disabled()
        {
            Debug.WriteLine("Keyboard disabled");
        }

        public void KeyPressed()
        {
            Debug.WriteLine("Keyboard key pressed");
        }
    }
}
