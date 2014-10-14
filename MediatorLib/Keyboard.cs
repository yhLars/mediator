using System.Diagnostics;

namespace MediatorLib
{
    public class Keyboard
    {
        private ComputerSystem _computerSystem;

        public Keyboard(ComputerSystem computerSystem)
        {
            _computerSystem = computerSystem;
            Debug.WriteLine("Keyboard is instantiated");
            _computerSystem.RegisterKeyboard(this);
        }

        public void Enabled()
        {
            Debug.WriteLine("Keyboard enabled");
        }

        public void Disabled()
        {
            Debug.WriteLine("Keyboard disabled");
        }

        public char KeyPressed(char keyPressed)
        {
            Debug.WriteLine("Keyboard key pressed: '" + keyPressed + "'");
            return keyPressed;
        }
    }
}
