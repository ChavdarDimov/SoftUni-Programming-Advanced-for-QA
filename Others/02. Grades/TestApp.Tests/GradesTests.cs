using System;
using System.Collections.Generic;
using NUnit.Framework;
using TestApp;

namespace TestApp.Tests
{
    [TestFixture]
    public class GradesTests
    {
        [Test]
        public void Test_GetBestStudents_ReturnsBestThreeStudents()
        {
            // Arrange
            Dictionary<string, int> grades = new()
            {
                ["Alice"] = 6,
                ["Bob"] = 3,
                ["Charlie"] = 3,
                ["David"] = 5,
                ["Eva"] = 4
            };

            // Act
            string result = Grades.GetBestStudents(grades);
            string expected = $"Alice with average grade 6.00" +
                $"{Environment.NewLine}David with average grade 5.00" +
                $"{Environment.NewLine}Eva with average grade 4.00";

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
        {
            // Arrange
            Dictionary<string, int> emptyGrades = new();

            // Act
            string result = Grades.GetBestStudents(emptyGrades);
            string expected = "";

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
        {
            // Arrange
            Dictionary<string, int> lessThanThreeGrades = new()
            {
                ["Alice"] = 6,
                ["Bob"] = 5
            };

            // Act
            string result = Grades.GetBestStudents(lessThanThreeGrades);
            string expected = $"Alice with average grade 6.00" +
                $"{Environment.NewLine}Bob with average grade 5.00";

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
        {
            // Arrange
            Dictionary<string, int> sameGrades = new()
            {
                ["Alice"] = 6 ,
                ["Bob"] = 6,
                ["David"] = 6,
                ["Eva"] = 6,
                ["Alorica"] = 6
            };

            // Act
            string result = Grades.GetBestStudents(sameGrades);
            string expected = $"Alice with average grade 6.00" +
                $"{Environment.NewLine}Alorica with average grade 6.00" +
                $"{Environment.NewLine}Bob with average grade 6.00";

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
