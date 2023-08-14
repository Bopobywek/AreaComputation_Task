using AreaComputation;
using FluentAssertions;

namespace AreaComputationTests;

public class CircleTests
{
    [Theory]
    [MemberData(nameof(CreateCircleWithValidParametersMemberData))]
    public void CreateCircle_WithValidParameters_ShouldSuccess(double radius)
    {
        var circle = new Circle(radius);
        circle.Radius.Should().BeApproximately(radius, 1E-9);
    }
    
    [Theory]
    [MemberData(nameof(CreateCircleWithInvalidParametersMemberData))]
    public void CreateCircle_WithInvalidParameters_ShouldThrow(double radius)
    {
        FluentActions.Invoking(() => new Circle(radius)).Should().Throw<ArgumentException>();
    }
    
    public static IEnumerable<object[]> CreateCircleWithValidParametersMemberData => CreateCircleWithValidParameters();

    public static IEnumerable<object[]> CreateCircleWithValidParameters()
    {
        yield return new object[]
        {
            1
        };
        yield return new object[]
        {
            2
        };
        yield return new object[]
        {
            100.231
        };
    }
    
    public static IEnumerable<object[]> CreateCircleWithInvalidParametersMemberData => CreateCircleWithInvalidParameters();

    public static IEnumerable<object[]> CreateCircleWithInvalidParameters()
    {
        yield return new object[]
        {
            -1
        };
        yield return new object[]
        {
            0
        };
        yield return new object[]
        {
            -13.43
        };
    }
}