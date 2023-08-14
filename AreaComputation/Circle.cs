namespace AreaComputation;

public class Circle : IAreaComputable
{
    private double _radius;
    public double Radius { get => _radius;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Radius should be positive");
            }

            _radius = value;
        }
    }
    public double Area => Math.PI * Radius * Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}