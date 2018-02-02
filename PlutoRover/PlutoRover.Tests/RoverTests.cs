using System;
using Xunit;

namespace PlutoRover.Tests
{
    public class RoverTests
    {
        [Theory]
        [InlineData(0, 0, 'N', 0, 1)]
        [InlineData(0, 0, 'E', 1, 0)]
		[InlineData(1, 1, 'S', 1, 0)]
		[InlineData(1, 1, 'W', 0, 1)]
		public void ExecuteCommands_F_ShouldMoveForward(int startX, int startY, char startDirection, int expectedX, int expectedY)
        {
			// Arrange
            var rover = new Rover(startX, startY, startDirection);

			// Act
			rover.ExecuteCommands("F");

			// Assert
            Assert.Equal(expectedX, rover.PositionX);
            Assert.Equal(expectedY, rover.PositionY);
            Assert.Equal(startDirection, rover.Direction);
		}

		[Theory]
		[InlineData(1, 1, 'N', 1, 0)]
		[InlineData(1, 1, 'E', 0, 1)]
		[InlineData(1, 1, 'S', 1, 2)]
		[InlineData(1, 1, 'W', 2, 1)]
		public void ExecuteCommands_B_ShouldMoveBackward(int startX, int startY, char startDirection, int expectedX, int expectedY)
		{
			// Arrange
			var rover = new Rover(startX, startY, startDirection);

			// Act
			rover.ExecuteCommands("B");

			// Assert
			Assert.Equal(expectedX, rover.PositionX);
			Assert.Equal(expectedY, rover.PositionY);
			Assert.Equal(startDirection, rover.Direction);
		}

		[Theory]
		[InlineData(1, 1, 'N', 1, 1, 'W')]
		[InlineData(1, 1, 'W', 1, 1, 'S')]
		[InlineData(1, 1, 'S', 1, 1, 'E')]
		[InlineData(1, 1, 'E', 1, 1, 'N')]
		public void ExecuteCommands_L_ShouldTurnRoverLeft(int startX, int startY, char startDirection, int expectedX, int expectedY, char expectedDirection)
		{
			// Arrange
			var rover = new Rover(startX, startY, startDirection);

			// Act
			rover.ExecuteCommands("L");

			// Assert
			Assert.Equal(expectedX, rover.PositionX);
			Assert.Equal(expectedY, rover.PositionY);
			Assert.Equal(expectedDirection, rover.Direction);
		}
	}
}
