using ToyRobotSimulator.Enums;

namespace ToyRobotSimulator.Models
{
    /// <summary>
    /// ToyRobot class to represent the robot in the simulator.
    /// </summary>
    public class ToyRobot
    {
        /// <summary>
        /// X coordinates of the robot.
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// Y coordinates of the robot.
        /// </summary>
        public int Y { get; private set; }

        /// <summary>
        /// RobotFacing direction the robot is facing.
        /// </summary>
        public Direction RobotFacing { get; private set; }

        /// <summary>
        /// IsPlaced flag to check if the robot is placed on the table.
        /// </summary>
        public bool IsPlaced { get; private set; }

        /// <summary>
        /// Place method to place the robot on the table.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="robotFacing"></param>
        public void Place(int x, int y, Direction robotFacing)
        {
            X = x;
            Y = y;
            RobotFacing = robotFacing;
            IsPlaced = true;
        }

        /// <summary>
        /// Move method to move the robot on the table.
        /// </summary>
        /// <param name="table"></param>
        public void Move(Table table)
        {
            if (!IsPlaced) return;

            var (valueX, valueY) = (X, Y);

            switch (RobotFacing)
            {
                case Direction.NORTH:
                    valueY++;
                    break;
                case Direction.EAST:
                    valueX++;
                    break;
                case Direction.SOUTH:
                    valueY--;
                    break;
                case Direction.WEST:
                    valueX--;
                    break;
            }

            if (table.IsValidPosition(valueX, valueY))
            {
                X = valueX;
                Y = valueY;
            }
        }

        /// <summary>
        /// TurnLeft method to turn the robot left.
        /// </summary>
        public void TurnLeft()
        {
            if (!IsPlaced) return;
            RobotFacing = (Direction)(((int)RobotFacing + 3) % 4); // Rotate counterclockwise
        }

        /// <summary>
        /// TurnRight method to turn the robot right.
        /// </summary>
        public void TurnRight()
        {
            if (!IsPlaced) return;
            RobotFacing = (Direction)(((int)RobotFacing + 1) % 4); // Rotate clockwise
        }

        /// <summary>
        /// Report method to return the current position of the robot.
        /// </summary>        
        public string Report()
        {
            return IsPlaced ? $"{X},{Y},{RobotFacing}" : "Robot not placed on the table.";
        }
    }
}
