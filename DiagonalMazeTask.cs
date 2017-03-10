using System;

namespace Mazes
{
	public static class DiagonalMazeTask
	{
        static int outerWalls = 2;
        public static void Move(Robot robot, int distance, Direction dir)
        {
            while (distance-- > 0)
                robot.MoveTo(dir);
        }
        public static void MoveLoop(Robot robot, int primaryMovement, int secondaryMovement, Direction dir1, Direction dir2)
        {
                Move(robot, (primaryMovement - 1) / secondaryMovement, dir1);
                Move(robot, 1, dir2);
        }
        public static void MoveOut(Robot robot, int width, int height)
		{
            Direction primaryDirection = Direction.Down, secondaryDirection = Direction.Right;
            width -= outerWalls;
            height -= outerWalls;
            if (width > height)
            {
                primaryDirection = Direction.Right;
                secondaryDirection = Direction.Down;
            }
            var i = Math.Min(height, width);
                while (i-- > 1)
                    MoveLoop(robot, Math.Max(width, height), Math.Min(height, width), primaryDirection, secondaryDirection);
                if (height != width)
                    Move(robot, (Math.Max(height, width) - 1) / Math.Min(height, width), primaryDirection);
            }
        }
	}