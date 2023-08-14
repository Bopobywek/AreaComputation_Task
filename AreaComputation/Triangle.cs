namespace AreaComputation;

public class Triangle : IAreaComputable
{
    public double Area
    {
        get
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }

    private double _a;
    private double _b;
    private double _c;

    public double A
    {
        get => _a;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The length of the side of the triangle must be positive");
            }

            _a = value;
        }
    }

    public double B
    {
        get => _b;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The length of the side of the triangle must be positive");
            }

            _b = value;
        }
    }

    public double C
    {
        get => _c;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The length of the side of the triangle must be positive");
            }

            _c = value;
        }
    }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public bool IsTriangleRight()
    {
        if (A > B && A > C)
        {
            return A * A - B * B - C * C == 0;
        }

        if (B > A && B > C)
        {
            return B * B - A * A - C * C == 0;
        }

        return C * C - A * A - B * B == 0;
    }
}