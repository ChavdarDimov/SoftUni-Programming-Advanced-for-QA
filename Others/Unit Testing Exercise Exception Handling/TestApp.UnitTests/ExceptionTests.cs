using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.UnitTests
{
    public class ExceptionTests
    {
        private Exceptions _exceptions = null!;

        [SetUp]
        public void SetUp()
        {
            this._exceptions = new Exceptions();
        }

        [Test]
        public void Test_Reverse_ValidString_ReturnsReversedString()
        {
            // Arrange
            string input = "hello";
            string expected = "olleh";

            // Act
            string result = this._exceptions.ArgumentNullReverse(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_Reverse_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => this._exceptions.ArgumentNullReverse(input));
        }

        [Test]
        public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
        {
            // Arrange
            decimal totalPrice = 100.0m;
            decimal discount = 10.0m;
            decimal expected = 90.0m;

            // Act
            decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
        {
            // Arrange
            decimal totalPrice = 100.0m;
            decimal discount = -10.0m;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount));
        }

        [Test]
        public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
        {
            // Arrange
            decimal totalPrice = 100.0m;
            decimal discount = 110.0m;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount));
        }

        [Test]
        public void Test_IndexOutOfRangeGetElement_ValidIndex_ReturnsElement()
        {
            // Arrange
            int[] array = { 1, 2, 3 };
            int index = 1;
            int expected = 2;

            // Act
            int result = this._exceptions.IndexOutOfRangeGetElement(array, index);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_IndexOutOfRangeGetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };
            int index = -1;

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => this._exceptions.IndexOutOfRangeGetElement(array, index));
        }

        [Test]
        public void Test_IndexOutOfRangeGetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };
            int index = 3;

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => this._exceptions.IndexOutOfRangeGetElement(array, index));
        }

        [Test]
        public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
        {
            // Arrange
            bool isLoggedIn = true;
            string expected = "User logged in.";

            // Act
            string result = this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
        {
            // Arrange
            bool isLoggedIn = false;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn));
        }

        [Test]
        public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
        {
            // Arrange
            string input = "123";
            int expected = 123;

            // Act
            int result = this._exceptions.FormatExceptionParseInt(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_ParseInt_InvalidInput_ThrowsFormatException()
        {
            // Arrange
            string input = "abc";

            // Act & Assert
            Assert.Throws<FormatException>(() => this._exceptions.FormatExceptionParseInt(input));
        }

        [Test]
        public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
        {
            // Arrange
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            };
            string key = "two";
            int expected = 2;

            // Act
            int result = this._exceptions.KeyNotFoundFindValueByKey(dictionary, key);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
        {
            // Arrange
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 }
            };
            string key = "four";

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => this._exceptions.KeyNotFoundFindValueByKey(dictionary, key));
        }

        [Test]
        public void Test_OverflowAddNumbers_NoOverflow_ReturnsSum()
        {
            // Arrange
            int a = int.MaxValue - 1;
            int b = 1;
            int expected = int.MaxValue; // Should cause overflow

            // Act
            int result = this._exceptions.OverflowAddNumbers(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_OverflowAddNumbers_PositiveOverflow_ThrowsOverflowException()
        {
            // Arrange
            int a = int.MaxValue;
            int b = 1;

            // Act & Assert
            Assert.Throws<OverflowException>(() => this._exceptions.OverflowAddNumbers(a, b));
        }

        [Test]
        public void Test_OverflowAddNumbers_NegativeOverflow_ThrowsOverflowException()
        {
            // Arrange
            int a = int.MinValue;
            int b = -1;

            // Act & Assert
            Assert.Throws<OverflowException>(() => this._exceptions.OverflowAddNumbers(a, b));
        }

        [Test]
        public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
        {
            // Arrange
            int dividend = 10;
            int divisor = 2;
            int expected = 5; // Expected result of 10 divided by 2

            // Act
            int result = this._exceptions.DivideByZeroDivideNumbers(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int dividend = 10;
            int divisor = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => this._exceptions.DivideByZeroDivideNumbers(dividend, divisor));
        }

        [Test]
        public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
        {
            // Arrange
            int[] collection = { 1, 2, 3, 4, 5 };
            int index = 3;
            int expected = 15; // 1 + 2 + 3 + 4 + 5 = 15

            // Act
            int result = this._exceptions.SumCollectionElements(collection, index);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
        {
            // Arrange
            int[] collection = null;
            int index = 0;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => this._exceptions.SumCollectionElements(collection, index));
        }

        [Test]
        public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            int[] collection = { 1, 2, 3 };
            int index = 5;

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => this._exceptions.SumCollectionElements(collection, index));
        }

        [Test]
        public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
        {
            // Arrange
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                { "one", "1" },
                { "two", "2" },
                { "three", "3" }
            };
            string key = "two";
            int expected = 2;

            // Act
            int result = this._exceptions.GetElementAsNumber(dictionary, key);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
        {
            // Arrange
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                { "one", "1" },
                { "two", "2" },
                { "three", "3" }
            };
            string key = "four";

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => this._exceptions.GetElementAsNumber(dictionary, key));
        }

        [Test]
        public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                { "one", "1" },
                { "two", "notANumber" },
                { "three", "3" }
            };
            string key = "two";

            // Act & Assert
            Assert.Throws<FormatException>(() => this._exceptions.GetElementAsNumber(dictionary, key));
        }
    }
}
