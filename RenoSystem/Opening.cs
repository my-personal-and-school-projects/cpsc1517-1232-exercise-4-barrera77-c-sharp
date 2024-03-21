namespace RenoSystem
{
    /// <summary>
    /// The purpose of this exercise is the use of simple data types to represent the primary objects for managing renovation projects
    /// </summary>
    public class Opening
    {
        //Fields
        private int _edging;
        private const int _Edging = 10;
        private int _height;
        private const int _Height = 120;
        private int _width;
        private const int _Width = 50;

        //Properties
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (!Utils.Utilities.IsNonZeroPositive(value))
                {
                    throw new ArgumentException($"The Height value: {value} is invalid. Must be a positive value.");
                }

                if (!Utils.Utilities.IsValidMinimum(value, _Height))
                {
                    throw new ArgumentException($"Height cannot be less than {_Height}cm");
                }
                _height = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (!Utils.Utilities.IsValidMinimum(value, _Width))
                {
                    throw new ArgumentException($"Width cannot be less than {_Width}cm");
                }
                _width = value;
            }
        }

        public int Edging
        {
            get
            {
                return _edging;
            }

            set
            {
                if (!Utils.Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentException("Edging cannot be less than 0");
                }
                else if (Utils.Utilities.IsNonZeroPositive(value) && !Utils.Utilities.IsValidMinimum(value, _Edging))
                {
                    throw new ArgumentException("Edging should be equals or greater than 10");
                }
                _edging = value;
            }
        }

        public int Area
        {
            get
            {
                return (Width * Height);
            }
        }

        public int Perimeter
        {
            get
            {
                return ((_width + _height) * 2);
            }
        }

        //Auto-implemented property
        public OpeningType? Type { get; set; }

        //Greedy onstructor
        public Opening(int width, int height, OpeningType? type, int edging = 0)
        {

            Height = height;
            Width = width;
            Type = type;
            Edging = edging;
        }

        //Methods        

        /// <summary>
        /// Overides the default ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Width},{Height},{Type},{Edging}";

        }
    }
}



