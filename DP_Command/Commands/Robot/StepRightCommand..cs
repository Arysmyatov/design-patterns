
namespace Dp_Command.Commands.Robot
{
    public class StepRight : ICommand
    {
        private Dp_Command.Toys.Robot _robot;


        public StepRight(Dp_Command.Toys.Robot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.StepForward();
        }

        public override string ToString()
        {
            return "step right";
        }
    }
}