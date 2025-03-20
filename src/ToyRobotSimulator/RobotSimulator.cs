using ToyRobotSimulator.Enums;
using ToyRobotSimulator.Models;

namespace ToyRobotSimulator
{
   public class RobotSimulator
    {
        /// <summary>
        /// Main method to run the robot simulator. It continuously reads commands from the console
        /// and executes them until the application is terminated.
        /// </summary>
        public static void RunRoobot()
        {
            var table = new Table(5, 5); // 5x5 table
            var robot = new ToyRobot();

            while (true)
            {
                Console.Write("Enter command: ");
                var input = Console.ReadLine()?.Trim().ToUpper();

                if (string.IsNullOrEmpty(input)) continue;

                if (input.StartsWith("PLACE"))
                {
                    var parts = input.Substring(6).Split(',');
                    if (parts.Length == 3 &&
                        int.TryParse(parts[0], out int x) &&
                        int.TryParse(parts[1], out int y) &&
                        Enum.TryParse(parts[2], out Direction direction))
                    {
                        if (table.IsValidPosition(x, y))
                        {
                            robot.Place(x, y, direction);
                        }
                        else
                        {
                            Console.WriteLine("Invalid PLACE coordinates.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid PLACE command.");
                    }
                }
                else if (input == "MOVE")
                {
                    robot.Move(table);
                }
                else if (input == "LEFT")
                {
                    robot.TurnLeft();
                }
                else if (input == "RIGHT")
                {
                    robot.TurnRight();
                }
                else if (input == "REPORT")
                {
                    Console.WriteLine(robot.Report());
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }
            }
        }
    }
}