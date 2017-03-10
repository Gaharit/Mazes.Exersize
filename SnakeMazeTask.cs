namespace Mazes
{
	public static class SnakeMazeTask
	{
        static int outerWalls = 2, loopHeight = 4;

        public static void Move(Robot robot, int distance, Direction dir)
        {
            while (distance-- > 1)
                robot.MoveTo(dir);
        }
        public static void MoveOut(Robot robot, int width, int height)
        {
            int loopsRemaining = (height - outerWalls + 1) / (loopHeight);
            while (loopsRemaining-- > 0)
            {
                Move(robot, width - outerWalls, Direction.Right);
                Move(robot, 3, Direction.Down);
                Move(robot, width - outerWalls, Direction.Left);
                if (!robot.Finished)
                    Move(robot, 3, Direction.Down);
            }
        }
    }
}