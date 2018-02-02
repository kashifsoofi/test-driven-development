using System;

namespace PlutoRover
{
    public class Rover
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char Direction { get; private set; }

        public Rover(int positionX, int positionY, char direction)
        {
            PositionX = positionX;
            PositionY = positionY;
            Direction = direction;
        }

        public void ExecuteCommands(string commands)
        {
            if (commands[0] == 'L')
            {
                TurnLeft();
            }
            else if (commands[0] == 'B')
            {
                MoveBackward();
            }
            else
            {
                MoveForward();
            }
        }

        private void MoveForward()
        {
			if (Direction == 'E')
				PositionX += 1;
			else if (Direction == 'S')
				PositionY -= 1;
			else if (Direction == 'W')
				PositionX -= 1;
			else
				PositionY += 1;
		}

        private void MoveBackward()
        {
			if (Direction == 'E')
				PositionX -= 1;
			else if (Direction == 'S')
				PositionY += 1;
			else if (Direction == 'W')
				PositionX += 1;
			else
				PositionY -= 1;
		}

        private void TurnLeft()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'W';
                    break;
                case 'W':
					Direction = 'S';
					break;
				case 'S':
					Direction = 'E';
					break;
				case 'E':
					Direction = 'N';
					break;
			}
		}
    }
}
