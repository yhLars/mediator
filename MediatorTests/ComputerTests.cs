using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediatorLib;

namespace MediatorTests
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void Test_That_All_Classes_Instantiate()
        {
            // ARRANGE
            const char expectedCharacterFromScreenDisplayCharacter = 'C';

            // ACT
            ComputerSystem computerSystem = new ComputerSystem();
            Computer computer = new Computer(computerSystem);
            Screen screen = new Screen(computerSystem);
            Keyboard keyboard = new Keyboard(computerSystem);

            computer.SwitchOn();
            keyboard.KeyPressed();
            char actualCharacterFromScreenDisplayCharacter = screen.DisplayCharacter(expectedCharacterFromScreenDisplayCharacter);

            // ASSERT
            Assert.AreEqual(expectedCharacterFromScreenDisplayCharacter, actualCharacterFromScreenDisplayCharacter);
        }
    }
}
