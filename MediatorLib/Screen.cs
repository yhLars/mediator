using System.Diagnostics;

namespace MediatorLib
{
    public class Screen
    {
                private ComputerSystem _computerSystem;

        public Screen(ComputerSystem computerSystem)
        {
            _computerSystem = computerSystem;
            _computerSystem.RegisterScreen(this);
            Debug.WriteLine("Screen is instantiated");
        }

        public void TurnOn()
        {
            Debug.WriteLine("Screen turned on");
        }

        public void TurnOff()
        {
            Debug.WriteLine("Screen turned off");
        }

        public char DisplayCharacter(char displayCaracter)
        {
            Debug.WriteLine("Screen displaying this character: '" + displayCaracter + "'");
            return displayCaracter;
        }
    }
}
