using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{

    [TestCase("unittests@gmail.com")]
    [TestCase("unit.tests@gmail.com")]
    [TestCase("unittests99@gmail.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange


        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }


    [TestCase("unitt--!ests@gmail.com")]
    [TestCase("unittests6/6@gmail.com")]
    [TestCase("unittests@gmail")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
