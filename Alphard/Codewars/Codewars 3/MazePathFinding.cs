namespace MazePathfinding
{
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public static int[] FindPath(bool[] maze, int size, int startIndex, int goalIndex)
        {
            var visitingQueue = new Queue<int>(new[] { startIndex });
            var cameFrom = new int?[maze.Length];

            while (visitingQueue.Count > 0)
            {
                var current = visitingQueue.Dequeue();

                if (current == goalIndex)
                {
                    // Solution found. Backtrack the path.
                    var list = new LinkedList<int>();

                    int? parent = current;
                    while (parent.HasValue)
                    {
                        list.AddFirst(parent.Value);
                        parent = cameFrom[parent.Value];
                    }

                    return list.ToArray();
                }

                var nextPoints = new[] { current - 1, current + 1, current - size, current + size }
                    .Where(x => x > 0 && x < maze.Length) // Is within the maze field
                    .Where(x => x != startIndex) // Is not a starting point
                    .Where(x => !cameFrom[x].HasValue) // Is not visited yet
                    .Where(x => maze[x]); // Is not a wall

                foreach (var next in nextPoints)
                {
                    cameFrom[next] = current;
                    visitingQueue.Enqueue(next);
                }
            }

            throw new("Path was not found");
        }
    }
}