
namespace Dp_Command.Commands.Robot
{
    public class StepBack : ICommand
    {
        private Dp_Command.Toys.Robot _robot;

        public StepBack(Dp_Command.Toys.Robot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.StepBack();
        }

        public override string ToString()
        {
            return "step back";
        }
    }
}