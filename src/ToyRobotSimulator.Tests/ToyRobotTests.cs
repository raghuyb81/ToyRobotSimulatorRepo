using ToyRobotSimulator.Enums;
using ToyRobotSimulator.Models;

namespace ToyRobotSimulator.Tests
{
    public class ToyRobotTests
    {
        [Fact]
        public void Place_ShouldSetInitialPositionAndFacing()
        {
            var robot = new ToyRobot();
            robot.Place(2, 3, Direction.EAST);

            Assert.Equal(2, robot.X);
            Assert.Equal(3, robot.Y);
            Assert.Equal(Direction.EAST, robot.RobotFacing);
        }

        [Fact]
        public void Move_ShouldNotAllowRobotToFall()
        {
            var table = new Table(5, 5);
            var robot = new ToyRobot();
            robot.Place(4, 4, Direction.NORTH);
            robot.Move(table);

            Assert.Equal(4, robot.X);
            Assert.Equal(4, robot.Y); // Robot stays in bounds
        }

        [Fact]
        public void TurnLeft_ShouldChangeFacingDirection()
        {
            var robot = new ToyRobot();
            robot.Place(1, 1, Direction.NORTH);
            robot.TurnLeft();

            Assert.Equal(Direction.WEST, robot.RobotFacing);
        }

        [Fact]
        public void TurnRight_ShouldChangeFacingDirection()
        {
            var robot = new ToyRobot();
            robot.Place(1, 1, Direction.NORTH);
            robot.TurnRight();

            Assert.Equal(Direction.EAST, robot.RobotFacing);
        }


        [Fact]
        public void Report_ShouldReturnCorrectPosition_WhenRobotIsPlaced()
        {
            // Arrange
            var robot = new ToyRobot();
            robot.Place(1, 2, Direction.NORTH);

            // Act
            var result = robot.Report();

            // Assert
            Assert.Equal("1,2,NORTH", result);
        }

        [Fact]
        public void Report_ShouldReturnNotPlacedMessage_WhenRobotIsNotPlaced()
        {
            // Arrange
            var robot = new ToyRobot();

            // Act
            var result = robot.Report();

            // Assert
            Assert.Equal("Robot not placed on the table.", result);
        }
    }
}