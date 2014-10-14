using System.Diagnostics;

namespace MediatorLib
{
    public class Computer
    {
        private ComputerSystem _computerSystem;

        public Computer(ComputerSystem computerSystem)
        {
            _computerSystem = computerSystem;
            Debug.WriteLine("Computer is instantiated");
            _computerSystem.RegisterComputer(this);
        }

        public void SwitchOn()
        {
            Debug.WriteLine("Computer switched on");
        }

        public void SwitchOff()
        {
            Debug.WriteLine("Computer switched off");
        }
    }
}
