using System;
using BowlingProject;
using Xunit;

namespace BowlingKataUnitTests
{
    public class BowlingKataUnitTests
    {
        private Game g;
        public BowlingKataUnitTests()
        {
            g = new Game();
        }


        [Fact]

        public void DoesGameExist()
        {
            
            Assert.NotNull(g);
        }

        [Fact]

        public void GutterGameReturns0()
        {
            //arrange

            //act
            rollMany(20, 0);

            //assert
            Assert.Equal(0, g.scoreGame());
        }
        [Fact]
        public void SinglePinGameReturns20()
        {
            //arrange

            //act
            rollMany(20, 1);

            //assert
            Assert.Equal(20, g.scoreGame());
        }

        [Fact]
        public void OneSpareReturnsAppropriateValue()
        {
            //arrange
            g.roll(5);
            g.roll(5); //spare
            g.roll(3);

            //act
            rollMany(17, 0);

            //assert
            Assert.Equal(16, g.scoreGame());
        }

        [Fact]
        public void OneStrikeReturnsAppropriateValue()
        {
            //arrange
            g.roll(10); //strike
            g.roll(3);
            g.roll(4);

            //act
            rollMany(16, 0);

            //assert
            Assert.Equal(24, g.scoreGame());
        }

        [Fact]
        public void PerfectGameReturns300()
        {
            //arrange
            
            //act
            rollMany(12, 10);

            //assert
            Assert.Equal(300, g.scoreGame());
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
