using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheQuest2019;

namespace TheQuest2019_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetDirection_DirectionIsUpClockwise_Right()
        {
            // arrange
            Direction input = Direction.Up;

            // act
            Direction output = Weapon.GetDirection(input, true);

            // assert
            Assert.AreEqual(Direction.Right, output);
        }

        [TestMethod]
        public void GetDirection_DirectionIsUpCounterclockwise_Left()
        {
            // arrange
            Direction input = Direction.Up;

            // act
            Direction output = Weapon.GetDirection(input, false);

            // assert
            Assert.AreEqual(Direction.Left, output);
        }

        [TestMethod]
        public void GetDirection_DirectionIsLeftClockwise_Up()
        {
            // arrange
            Direction input = Direction.Left;

            // act
            Direction output = Weapon.GetDirection(input, true);

            // assert
            Assert.AreEqual(Direction.Up, output);
        }

        [TestMethod]
        public void GetDirection_DirectionIsLeftCounterclockwise_Down()
        {
            // arrange
            Direction input = Direction.Left;

            // act
            Direction output = Weapon.GetDirection(input, false);

            // assert
            Assert.AreEqual(Direction.Down, output);
        }

        [TestMethod]
        public void GetDirection_DirectionIsLeft4TimesClockwise_Left()
        {
            // arrange
            Direction input = Direction.Left;

            // act
            for (int i = 0; i < 4; i++)
            {
                input = Weapon.GetDirection(input, true);
            }

            // assert
            Assert.AreEqual(Direction.Left, input);
        }
    }
}
