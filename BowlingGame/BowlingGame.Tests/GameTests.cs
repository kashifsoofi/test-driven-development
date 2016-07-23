using NUnit.Framework;
using System;
namespace BowlingGame.Tests
{
    [TestFixture()]
    public class GameTests
    {
        private Game g;

        [SetUp]
        public void SetUp()
        {
            g = new Game();
        }

        [Test]
        public void DoesGameExists()
        {
            // arrange
            // act
            // assert
            Assert.NotNull(g);
        }

        [Test]
        public void GutterGameReturns0()
        {
            // arrange

            // act
            rollMany(20, 0);
            int actual = g.scoreGame();

            // assert
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void SinglePinGameReturns20()
        {
            // arrange

            // act
            rollMany(20, 1);
            int actual = g.scoreGame();

            // assert
            Assert.That(actual, Is.EqualTo(20));
        }

        [Test]
        public void OneSpareReturnsAppropriateValue()
        {
            // arrange
            g.roll(5);
            g.roll(5); // spare
            g.roll(3);

            // act
            rollMany(17, 0);
            int actual = g.scoreGame();

            // assert
            Assert.That(actual, Is.EqualTo(16));
        }

        [Test]
        public void OneStrikeReturnsAppropriateValue()
        {
            // arrange
            g.roll(10); // strike
            g.roll(3);
            g.roll(4);

            // act
            rollMany(16, 0);
            int actual = g.scoreGame();

            // assert
            Assert.That(actual, Is.EqualTo(24));
        }

        [Test]
        public void PerfectGameReturns300()
        {
            // arrange

            // act
            rollMany(12, 10);
            int actual = g.scoreGame();

            // assert
            Assert.That(actual, Is.EqualTo(300));
        }

        public void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.roll(pins);
            }
        }
    }
}

