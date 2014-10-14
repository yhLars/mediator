using System.Diagnostics;

namespace MediatorLib
{
    public class ComputerSystem
    {
        private Computer _computer;
        private Keyboard _keyboard;
        private Screen _screen;

        internal void RegisterComputer(Computer computer)
        {
            _computer = computer;
            Debug.WriteLine("Computer is registered");
        }
        internal void RegisterKeyboard(Keyboard keyboard)
        {
            _keyboard = keyboard;
            Debug.WriteLine("Keyboard is registered");
        }
        internal void RegisterScreen(Screen screen)
        {
            _screen = screen;
            Debug.WriteLine("Screen is registered");
        }


        internal void ComputerSwitchedOn(Computer computer)
        {
            _computer.SwitchOn();
        }

        internal void ComputerSwitchedOff(Computer computer)
        {
            _computer.SwitchOff();
        }

        internal void KeyboardKeyPressed(Keyboard keyboard)
        {
            _keyboard.KeyPressed();
        }
    }
}
