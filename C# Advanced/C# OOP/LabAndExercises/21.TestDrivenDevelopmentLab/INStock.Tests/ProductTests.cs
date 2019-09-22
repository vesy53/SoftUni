namespace INStock.Tests
{
    using NUnit.Framework;
    using System;

    using INStock.Contracts;
    using INStock.Models;

    public class ProductTests
    {
        // Test list
        // Write test
        // Add method
        // Run and fail
        // Write code
        // Run and ?

        [Test]
        public void Constructor_ShouldInitializeCorrectValues()
        {
            string label = "SSD";
            decimal price = 12.34M;
            int quantity = 3;

            IProduct product = new Product(label, price, quantity);

            Assert.AreEqual(label, product.Label);
            Assert.AreEqual(price, product.Price);
            Assert.AreEqual(quantity, product.Quantity);
        }

        [Test]
        public void Constructor_InvalidLabel_ShouldThrowArgumentNullException()
        {
            string invalidLabel = null;
            decimal price = 12.34M;
            int quantity = 3;

            Assert
                .Throws<ArgumentNullException>(
                    () => new Product(invalidLabel, price, quantity));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(-500)]
        public void Constructor_InvalidPrice_ShouldThrowArgumentException(
            decimal price)
        {
            string label = "HDD";
            int quantity = 3;

            Assert
                .Throws<ArgumentException>(
                    () => new Product(label, price, quantity));
        }

        [Test]
        public void Constructor_InvalidQuantity_ShouldThrowArgumentException()
        {
            string label = "HDD";
            decimal price = 55.45M;
            int invalidQuantity = -5;

            Assert
                .Throws<ArgumentException>(
                    () => new Product(label, price, invalidQuantity));

        }

        [Test]
        public void CompareTo_ShouldReturnLabelWithGreaterAsciiCode()
        {
            string greaterProductLable = "Zoom";
            decimal greaterProductPrice = 34.12M;
            int greaterProductQuantity = 2;

            string smallProductLable = "Do";
            decimal smallProductPrice = 12.34M;
            int smallProductQuantity = 4;

            IProduct greaterProduct = new Product(
                greaterProductLable,
                greaterProductPrice,
                greaterProductQuantity);
            IProduct smallerProduct = new Product(
                smallProductLable,
                smallProductPrice,
                smallProductQuantity);

            int actualResult = greaterProduct.CompareTo(smallerProduct);
            int expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}