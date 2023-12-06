using ChalengeApp;

namespace ChallengeApp.Tests;

public class Tests
{
    [Test]
    public void WhenEmployeeCollectPoints_ShouldReturnCorrectResult()
    {
        // arrange
        var employee = new Employee("Piotr", "Newman", 44);
        // act
        employee.AddScore(5);
        employee.AddScore(9);
        employee.AddScore(-19);
        employee.AddScore(21);

        // assert
        Assert.AreEqual(16, employee.Result);
    }
}