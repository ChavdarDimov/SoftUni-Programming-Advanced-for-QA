using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        // Arrange
        string input = "Hello my name is John Wick";
        string start = "my";
        string end = "Wick";
        string expected = " name is John ";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello my name is John Wick";
        string start = "blabla";
        string end = "Wick";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello my name is John Wick";
        string start = "Hello";
        string end = "Wicked";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello my name is John Wick";
        string start = "blabla";
        string end = "Wicked";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "";
        string start = "blabla";
        string end = "Wick";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello my name is John Wick";
        string start = "Wick";
        string end = "Wick";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
