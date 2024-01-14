using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = "";
        string[] expected = new string[] {  };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "1";
        string[] expected = new string[] { "1" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "1,2,3,4,5";
        string[] expected = new string[] { "1", "2", "3", "4", "5" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = "1, 3, 4";
        string[] expected = new string[] { "1", "3", "4" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
