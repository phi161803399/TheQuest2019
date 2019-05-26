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
    }
}
