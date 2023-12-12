using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input=string.Empty;
        int rotator=3;
        //Act
        string result=StringRotator.RotateRight(input, rotator);
        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {  
        //Arrange
        string input = "Sofia";
        int rotator = 0;
        //Act
        string result = StringRotator.RotateRight(input, rotator);
        //Assert
        Assert.That(result, Is.EqualTo("Sofia"));

    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        string input = "Sofia";
        int rotator = 3;
        //Act
        string result = StringRotator.RotateRight(input, rotator);
        //Assert
        Assert.That(result, Is.EqualTo("fiaSo"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        string input = "Sofia";
        int rotator = 5;
        //Act
        string result = StringRotator.RotateRight(input, rotator);
        //Assert
        Assert.That(result, Is.EqualTo("Sofia"));

    }
    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        string input = "Sofia";
        int rotator = 7;
        //Act
        string result = StringRotator.RotateRight(input, rotator);
        //Assert
        Assert.That(result, Is.EqualTo("iaSof"));
    }
}
