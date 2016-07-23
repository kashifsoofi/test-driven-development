using NUnit.Framework;
using System;
namespace FibonacciNumber.Tests
{
    [TestFixture()]
    public class FibonacciTests
    {
        [Test]
        public void Fib_Given0_Return0()
        {
            // arrange
            int n = 0;

            // act
            int actual = Fibonacci.Fib(n);

            // assert
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void Fib_Given1_Return1()
        {
            // arrange
            int n = 1;

            // act
            int actual = Fibonacci.Fib(n);

            // assert
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void Fib_Given2_Return1()
        {
            // arrange
            int n = 2;

            // act
            int actual = Fibonacci.Fib(n);

            // assert
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void Fib_Given3_Return2()
        {
            // arrange
            int n = 3;

            // act
            int actual = Fibonacci.Fib(n);

            // assert
            Assert.That(actual, Is.EqualTo(2));
        }

        [Test]
        public void Fib_Given4_Return3()
        {
            // arrange
            int n = 4;

            // act
            int actual = Fibonacci.Fib(n);

            // assert
            Assert.That(actual, Is.EqualTo(3));
        }
    }
}

