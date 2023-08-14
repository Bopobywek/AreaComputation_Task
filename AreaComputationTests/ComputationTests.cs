using AreaComputation;
using FluentAssertions;

namespace AreaComputationTests;

public class ComputationTests
{
    [Theory]
    [MemberData(nameof(CalculateCircleAreaMemberData))]
    public void CalculateCircleArea_ShouldSuccess(double radius, double answer)
    {
        var circle = new Circle(radius);
        circle.Area.Should().BeApproximately(answer, 1E-9);
    }
    
    [Theory]
    [MemberData(nameof(CalculateTriangleAreaMemberData))]
    public void CalculateTriangleArea_ShouldSuccess(double a, double b, double c, double answer)
    {
        var triangle = new Triangle(a, b, c);
        triangle.Area.Should().BeApproximately(answer, 1E-9);
    }

    public static IEnumerable<object[]> CalculateCircleAreaMemberData => CalculateCircleArea();

    public static IEnumerable<object[]> CalculateTriangleAreaMemberData => CalculateTriangleArea();

    public static IEnumerable<object[]> CalculateCircleArea()
    {
        yield return new object[]
        {
            2, Math.PI * 2 * 2
        };
        yield return new object[]
        {
            7.34, Math.PI * 7.34 * 7.34
        };
        yield return new object[]
        {
            10.12, Math.PI * 10.12 * 10.12
        };
    }

    public static IEnumerable<object[]> CalculateTriangleArea()
    {
        yield return new object[]
        {
            3, 4, 5, 6
        };
        yield return new object[]
        {
            1.5, 4.8, 5, 3.5992698912418
        };
        yield return new object[]
        {
            1, 1, 1, 0.43301270189222
        };
    }
}