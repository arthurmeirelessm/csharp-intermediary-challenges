using csharp_intermediary_challenges;
using System;
using Xunit;

namespace ChallengesTest
{
    public class ChallengeTests
    {
        [Fact]
        public void FullNameMonthTestSuccess()
        {
            //Arrange
            var value = "abril";
            
            //Act
            MethodsChallenge methodsChallenge = new MethodsChallenge();
            var response = methodsChallenge.FullNameMonth(4);

            //Assert
            Assert.Equal(value, response);


        }

        [Fact]
        public void FullNameMonthTestFail()
        {
            //Arrange
            int value = 0;

            //Act
            MethodsChallenge methodChallenge = new MethodsChallenge();
            var response = methodChallenge.FullNameMonth(45);

            //Assert
            Assert.Equal(value, response);
        }
    }
}
