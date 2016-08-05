using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dp_Command.Commands;
using Dp_Command.Commands.RemoteControls;
using Dp_Command.Commands.Robot;
using Dp_Command.Toys;

namespace DP_Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var remote = new RemoteControl();
            string userInput;

            remote.SetCommandForButton(1, new StepForward (new Robot()));
            remote.SetCommandForButton(2, new StepBack (new Robot()));
            remote.SetCommandForButton(3, new StepLeft (new Robot()));
            remote.SetCommandForButton(4, new StepRight (new Robot()));
            
            do
            {
                Console.WriteLine("Chose the option below:");
                Console.WriteLine(remote);

                Console.Write("\nYour choise: ");
                var input = Console.ReadLine();
                int buttonId;
                int.TryParse(input, out buttonId);

                remote.PushButton(buttonId);

                Console.Write("\nDo you want to continue (y/n): ");
                userInput = Console.ReadLine();
            } while (userInput == "y");
            
        }
    }
}
