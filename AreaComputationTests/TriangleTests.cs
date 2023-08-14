using AreaComputation;
using FluentAssertions;

namespace AreaComputationTests;

public class TriangleTests
{
    [Theory]
    [MemberData(nameof(CreateTriangleWithValidParametersMemberData))]
    public void CreateTriangle_WithValidParameters_ShouldSuccess(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        triangle.A.Should().BeApproximately(a, 1E-9);
        triangle.B.Should().BeApproximately(b, 1E-9);
        triangle.C.Should().BeApproximately(c, 1E-9);
    }
    
    [Theory]
    [MemberData(nameof(CreateTriangleWithInvalidParametersMemberData))]
    public void CreateTriangle_WithInvalidParameters_ShouldThrow(double a, double b, double c)
    {
        FluentActions.Invoking(() => new Triangle(a, b, c)).Should().Throw<ArgumentException>();
    }
    
    [Theory]
    [MemberData(nameof(IsTriangleRightMemberData))]
    public void IsTriangleRight_ShouldSuccess(double a, double b, double c, bool answer)
    {
        var triangle = new Triangle(a, b, c);
        triangle.IsTriangleRight().Should().Be(answer);
    }
    
    public static IEnumerable<object[]> IsTriangleRightMemberData => IsTriangleRight();

    public static IEnumerable<object[]> IsTriangleRight()
    {
        yield return new object[]
        {
            3, 4, 5, true
        };
        yield return new object[]
        {
            3.1, 4.5, 6, false
        };
    }
    
    public static IEnumerable<object[]> CreateTriangleWithValidParametersMemberData => CreateTriangleWithValidParameters();

    public static IEnumerable<object[]> CreateTriangleWithValidParameters()
    {
        yield return new object[]
        {
            2, 4.2, 8
        };
        yield return new object[]
        {
            2.1, 5.6, 7
        };
        yield return new object[]
        {
            10.12, 7, 8
        };
    }
    
    public static IEnumerable<object[]> CreateTriangleWithInvalidParametersMemberData => CreateTriangleWithInvalidParameters();

    public static IEnumerable<object[]> CreateTriangleWithInvalidParameters()
    {
        yield return new object[]
        {
            -1, 2, 4
        };
        yield return new object[]
        {
            7.2, -1, 4
        };
        yield return new object[]
        {
            12, 0, -13.43
        };
    }
}