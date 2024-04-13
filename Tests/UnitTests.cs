using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid_Waller()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid_Waller()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_Waller()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        [Test]
        public void Subtract_Valid_Waller()
        {
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(-4, Program.Subtract("3", "7"));
            Assert.AreEqual(0, Program.Subtract("5", "5"));
        }

        [Test]
        public void Subtract_Invalid_Waller()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "b"));
            Assert.Throws<FormatException>(() => Program.Subtract("b", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("b", "b"));
        }

        [Test]
        public void Subtract_Null_Waller()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_Valid_Waller()
        {
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(21, Program.Multiply("3", "7"));
            Assert.AreEqual(25, Program.Multiply("5", "5"));
        }

        [Test]
        public void Multiply_Invalid_Waller()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "c"));
            Assert.Throws<FormatException>(() => Program.Multiply("c", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("c", "c"));
        }

        [Test]
        public void Multiply_Null_Waller()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_Valid_Waller()
        {
            Assert.AreEqual(1.5, Program.Divide("3", "2"));
            Assert.AreEqual(0.42857142857142855, Program.Divide("3", "7"));  // Intentional fail: expecting wrong precision
            Assert.AreEqual(1, Program.Divide("5", "5"));
        }

        [Test]
        public void Divide_Invalid_Waller()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "d"));
            Assert.Throws<FormatException>(() => Program.Divide("d", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("d", "d"));
        }

        [Test]
        public void Divide_Null_Waller()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
    }
}