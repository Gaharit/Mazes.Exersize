namespace Mazes
{
	public static class PyramidMazeTask
    {
        static int outerWalls = 2, loopHeight = 4, widthReduction = 2;

        public static void Move(Robot robot, int distance, Direction dir)
        {
            while (distance-- > 1)
                robot.MoveTo(dir);
        }

        public static int MoveLoop(Robot robot, int width)
        {
            return width;
        }
        public static void MoveOut(Robot robot, int width, int height)
        {

            int loopsRemaining = (height - outerWalls + 1) / loopHeight;
            width -= outerWalls;
            while (loopsRemaining-- > 0)
            {
                Move(robot, width, Direction.Right);
                width -= widthReduction;
                Move(robot, 3, Direction.Up);
                Move(robot, width, Direction.Left);
                width -= widthReduction;
                if (!robot.Finished)
                Move(robot, 3, Direction.Up);
            }
        }
    }
}