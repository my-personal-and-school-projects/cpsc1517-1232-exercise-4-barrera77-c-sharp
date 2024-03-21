using Utils;

namespace RenoSystem
{
    /// <summary>
    /// This project is a set of set of exercises that follow the evolution of a program to manage renovation projects
    /// </summary>
    public class Room
    {
        //Fields
        private string _Name;

        //Properties       
        public string Name { 
            get 
            { 
                return _Name; 
            }
            set
            {
                if(Utilities.IsNullEmptyOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentNullException("The name of the room cannot be null, empty or whitespace");
                }
                _Name = value.Trim();
            }
        }
        public string Flooring { get; set; }
        public List<Wall> Walls { get; private set; } = new List<Wall>();
        public int TotalWalls => Walls.Count;

        //Methods

        /// <summary>
        /// Adds a wall to the room
        /// </summary>
        /// <param name="wall"></param>
        /// <exception cref="ArgumentNullException">if the wall is null</exception>
        public void AddWall (Wall wall)
        {
            if (wall == null)
            {
                throw new ArgumentNullException("Wall cannot be null");
            }
            else if (Walls.Any(existingWall => existingWall.PlanId == wall.PlanId))
            {
                throw new ArgumentNullException("The room cannot have 2 walls with the same Plan Id");
            }
            Walls.Add(wall);
        }

        /// <summary>
        /// Removes a wall from the room based on a plan id
        /// </summary>
        /// <param name="planId"></param>
        /// <exception cref="ArgumentException">if the plan id is not valid</exception>
        public void RemoveWall(string planId)
        {     
            if (Utilities.IsNullEmptyOrWhiteSpace(planId))
            {
                throw new ArgumentNullException("The plan ID cannot be null or empty");
            }

            if (!Walls.Any(removedWall => removedWall.PlanId == planId))
            {
                throw new ArgumentNullException($"There is no wall {planId} in this room");
            }
            Walls.RemoveAll(wall => wall.PlanId == planId);                      
        }

        //Constructors
        public Room(string name, string flooring, List<Wall> walls)
        {
            if (walls == null)
            {
                throw new ArgumentNullException("Walls cannot be null");
            }
            if (Utilities.IsNullEmptyOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The name of the room cannot be null or empty");
            }
            Name = name.Trim();
            Flooring = flooring.Trim();
            Walls = walls;
        }

    }
}
