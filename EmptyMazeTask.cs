namespace Mazes
{
	public static class EmptyMazeTask
	{
        static int outerWalls = 2;

        public static void Move(Robot robot, int distance, Direction dir)
        {
            while (distance-- > 1)
                robot.MoveTo(dir);
        }
        public static void MoveOut(Robot robot, int width, int height)
		{
            Move(robot, width - outerWalls, Direction.Right);
            Move(robot, height - outerWalls, Direction.Down);
		}
	}
}