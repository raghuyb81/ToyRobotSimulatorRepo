namespace ToyRobotSimulator.Models
{
   public class Table
    {
        /// <summary>
        /// Width of the table.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Height of the table.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Table constructor.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Table(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// IsValidPosition method to check if the given position is valid on the table.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < Width && y >= 0 && y < Height;
        }
    }
}
