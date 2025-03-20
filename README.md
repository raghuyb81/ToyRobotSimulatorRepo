# Toy Robot Simulator
Overview
The Toy Robot Simulator is a C# application that simulates the movement of a toy robot on a square tabletop. The robot follows commands like PLACE, MOVE, LEFT, RIGHT, and REPORT, ensuring it doesn't fall off the table. This project showcases clean code practices, unit testing, and command-driven logic.
## Description
The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5 units.

There are no other obstructions on the table surface.

The robot is free to roam around the surface of the table, but it must be prevented from falling. Any movement that would result in the robot falling from the table must be prevented, while further valid movement commands must still be allowed.

The application accepts the following commands:

- `PLACE X,Y,F`: Places the toy robot on the table at position (X,Y) and facing one of the four cardinal directions: NORTH, SOUTH, EAST, or WEST. The origin (0,0) is the SOUTH-WEST corner of the table.
- `MOVE`: Moves the toy robot one unit forward in the direction it is currently facing.
- `LEFT`: Rotates the robot 90 degrees to the left without changing its position.
- `RIGHT`: Rotates the robot 90 degrees to the right without changing its position.
- `REPORT`: Outputs the robot's current X,Y position and facing direction.

## Key Features
- The first valid command must be a PLACE command. Any sequence of commands before a valid PLACE command will be ignored.
- Any movement that would cause the robot to fall off the table will also be ignored.
- The robot will ignore the commands MOVE, LEFT, RIGHT, and REPORT if it has not been placed on the table.

## Installation
1. Clone the repository:
   

