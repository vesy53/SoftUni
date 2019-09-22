namespace INStock.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    using INStock.Contracts;
    using INStock.Models;

    public class ProductStockTests
    {
        private IProductStock productStock;
        private IProduct product;

        [SetUp]
        public void SetUp()
        {
            this.productStock = new ProductStock();
            this.product = new Product("SDD", 12.34M, 4);
        }

        [Test]
        public void Constructor_ShouldInitializeTheArray()
        {
            int expectedValue = 4;
            int actualValue = this.productStock.Capacity;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Add_ShouldAddSuccessfully()
        {
            this.productStock.Add(this.product);

            int expectedValue = 1;
            int actualValue = productStock.Count;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Add_ShouldResizeWhenCountIsEqualToArrayLength()
        {
            Product[] products = new Product[]
            {
                new Product("Test1", 12, 12),
                new Product("Test2", 12, 12),
                new Product("Test3", 12, 12),
                new Product("Test4", 12, 12),
                new Product("Test5", 12, 12)
            };

            foreach (Product product in products)
            {
                this.productStock.Add(product);
            }

            int expectedValue = 8;
            int actualValue = this.productStock.Capacity;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Add_ShouldThrowInvalidOperationExceptionWhenNullIsPassed()
        {
            Assert.Throws<InvalidOperationException>(
                () => this.productStock.Add(null));
        }

        // Set Invalid index = out of
        // Set Valid index = assert are equal
        // Get Invalid index = out of
        // Get Valid index retuen product
        [Test]
        public void Set_InvalidIndex_ShouldReturnOutOfBoundaryException()
        {            
            Assert.Throws<IndexOutOfRangeException>(
                () => this.productStock[this.productStock.Capacity + 2] =this. product);
        }

        [Test]
        public void Set_ValidIndex_ShouldSetSuccessfully()
        {
            this.productStock[0] = this.product;

            IProduct actualValue = this.productStock[0];

            Assert.AreSame(product, actualValue);
        }

        [Test]
        public void Get_ValidIndex_ShouldReturnValue()
        {
            this.productStock.Add(this.product);

            IProduct actualProduct = this.productStock[0];

            Assert.AreSame(product, actualProduct);
        }

        [Test]
        public void Get_InvalidIndex_ShouldThrowOutOfRangeException()
        {
            this.productStock.Add(this.product);
            IProduct newProduct = null;

            Assert.Throws<IndexOutOfRangeException>(
                () => newProduct = this.productStock[2]);
        }

        [Test]
        public void Contains_ShouldReturnTrueWhenProductExist()
        {
            this.productStock.Add(this.product);

            bool actualResult = this.productStock.Contains(this.product);

            Assert.That(() => actualResult, Is.True);
        }

        [Test]
        public void Contains_ShouldReturnFalseWhenProductNonExist()
        {
            this.productStock.Add(this.product);

            this.product = new Product("HDD", 14.05M, 7);

            bool actualResult = this.productStock.Contains(this.product);
            
            Assert.That(() => actualResult, Is.False);
        }

        [Test]
        public void Contains_ShouldThrowExceptionWhenSearchProductThatIsNull()
        {
            Assert.That(
                () => this.productStock.Contains(null),
                Throws
                .InvalidOperationException
                .With
                .Message
                .EqualTo("Cannot accept null"));
        }

        [Test]
        public void Find_ShouldWorkCorrect()
        {
            this.productStock.Add(this.product);

            int index = 1;

            IProduct expectedProduct = this.product;
            IProduct actualProduct = this.productStock.Find(index);

            Assert.AreSame(expectedProduct, actualProduct);
        }

        [Test]
        [TestCase(-5)]
        [TestCase(6)]
        public void Find_ShouldThrowIndexOutOfRangeException(
            int index)
        {
            Assert.Throws<IndexOutOfRangeException>(
                () => this.productStock.Find(index));
        }

        [Test]
        [TestCase(-9)]
        [TestCase(0)]
        public void FindAllByPrice_WhenSearchInvalidPriceThrowException(
            double price)
        {
            Assert.That(
                () => this.productStock.FindAllByPrice(price),
                Throws
                .ArgumentException
                .With
                .Message
                .EqualTo("Search price cannot be zero or negative!"));
        }

        [Test]
        public void FindAllByPrice_ShouldWorkCorrect()
        {
            IProduct secondProduct = new Product("HDD", 12.34M, 2);
            IProduct thirdProduct = new Product("DDH", 10.50M, 3);

            this.productStock.Add(this.product);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);

            List<IProduct> equalPrice = new List<IProduct>();

            equalPrice.Add(this.product);
            equalPrice.Add(secondProduct);

            double price = 12.34;
            var actualProducts = this.productStock.FindAllByPrice(price);

            Assert.That(actualProducts, Is.EquivalentTo(equalPrice));
        }

        [Test]
        public void FindAllByQuantity_WhenSearchInvalidQuantityThrowException()
        {
            Assert.That(
                () => this.productStock.FindAllByQuantity(-9),
                Throws
                .ArgumentException
                .With
                .Message
                .EqualTo("Search quantity cannot be negative!"));
        }

        [Test]
        public void FindAllByQuantity_WhenWorkCorrect()
        {
            IProduct secondProduct = new Product("HDD", 12.34M, 2);
            IProduct thirdProduct = new Product("DDH", 10.50M, 4);

            this.productStock.Add(this.product);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);

            List<IProduct> equalQuantity = new List<IProduct>();

            equalQuantity.Add(this.product);
            equalQuantity.Add(thirdProduct);

            int quantity = 4;
            var actualProducts = this.productStock.FindAllByQuantity(quantity);

            Assert.That(actualProducts, Is.EquivalentTo(equalQuantity));
        }

        [Test]
        [TestCase(0, 4)]
        [TestCase(-5, 2)]
        [TestCase(1, 0)]
        [TestCase(1, -9)]
        public void FindAllInRange_InvalidRange_ShouldReturnException(
            double lo, double hi)
        {
            Assert.That(
                () => this.productStock.FindAllInRange(lo, hi),
                Throws
                .ArgumentException
                .With
                .Message
                .EqualTo("Value cannot be zero or negative!"));
        }

        [Test]
        [TestCase(10, 15)]
        [TestCase(15, 10)]
        public void FindAllInRange_ShouldWorkCorrect(
            double lo, double hi)
        {
            IProduct secondProduct = new Product("HDD", 10.50M, 2);
            IProduct thirdProduct = new Product("DDH", 20.70M, 5);

            this.productStock.Add(this.product);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);

            List<IProduct> equalQuantity = new List<IProduct>();

            equalQuantity.Add(this.product);
            equalQuantity.Add(secondProduct);

            var actualProducts = this.productStock.FindAllInRange(lo, hi);

            Assert.That(actualProducts, Is.EquivalentTo(equalQuantity));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void FindByLabel_InvalidLable_ShouldReturnException(
            string lable)
        {
            Assert.That(
                () => this.productStock.FindByLabel(lable),
                Throws
                .ArgumentException
                .With
                .Message
                .EqualTo("Label cannot be null or empty!"));
        }

        [Test]
        public void FindByLabel_ShouldWorkCorrect()
        {
            this.productStock.Add(this.product);

            IProduct actalProduct = this.productStock
                .FindByLabel(this.product.Label);

            Assert.AreEqual(this.product, actalProduct);
        }

        [Test]
        public void FindMostExpensiveProduct_ShouldWorcCorrect()
        {
            IProduct secondProduct = new Product("HDD", 12.34M, 2);
            IProduct thirdProduct = new Product("DDH", 20.50M, 4);

            this.productStock.Add(this.product);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);

            IProduct actualProduct = this.productStock.FindMostExpensiveProduct();

            Assert.AreEqual(thirdProduct, actualProduct);
        }

        [Test]
        public void Remove_ShouldRemoveSuccessfullyRpoduct()
        {
            this.productStock.Add(this.product);
            this.productStock.Remove(this.product);

            int expectedValue = 0;
            int actualValue = this.productStock.Count;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Remove_ShouldReorderCorrectly()
        {
            Product[] products = new Product[]
            {
                new Product("Test1", 12, 12),
                new Product("Test2", 12, 12),
                new Product("FailProduct", 12, 12),
                new Product("Test3", 12, 12),
                new Product("Test4", 12, 12),
                new Product("Test5", 12, 12),
                new Product("Test6", 12, 12),
                new Product("Test7", 12, 12)
            };

            foreach (Product product in products)
            {
                this.productStock.Add(product);
            }

            this.productStock.Remove(products[2]);

            for (int i = 2; i < this.productStock.Count; i++)
            {
                Assert.AreEqual(products[i + 1], this.productStock[i]);
            }
        }

        [Test]
        public void Remove_ShouldShrinkWhenTheLengthIsHalfEmpty()
        {
            Product[] products = new Product[]
            {
                new Product("Test1", 12, 12),
                new Product("Test2", 12, 12),
                new Product("Test3", 12, 12),
                new Product("Test4", 12, 12),
                new Product("Test5", 12, 12),
            };

            foreach (Product product in products)
            {
                this.productStock.Add(product);
            }

            this.productStock.Remove(products[3]);

            int expectedValue = 4;
            int actualValue = this.productStock.Capacity;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Remove_ShouldReturnFalseWhenProductWasNotFound()
        {
            bool actualResult = this.productStock.Remove(this.product);

            Assert.That(() => actualResult, Is.False);
        }

        [Test]
        public void GetEnumerator_ShouldWorkCorrect()
        {
            IProduct secondProduct = new Product("HDD", 12.34M, 2);
            IProduct thirdProduct = new Product("DDH", 20.50M, 4);

            this.productStock.Add(this.product);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);

            List<IProduct> allProducts = new List<IProduct>();

            allProducts.Add(this.product);
            allProducts.Add(secondProduct);
            allProducts.Add(thirdProduct);

            for (int i = 0; i < this.productStock.Count; i++)
            {
                Assert.AreEqual(allProducts[i], this.productStock[i]);
            }
        }
    }
}
