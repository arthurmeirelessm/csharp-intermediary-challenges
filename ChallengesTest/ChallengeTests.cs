using csharp_intermediary_challenges;
using System;
using Xunit;

namespace ChallengesTest
{
    public class ChallengeTests
    {
        [Fact]
        public void FullNameMonthTest()
        {
            //Arrange
            var value = "abril";
            
            //Act
            MethodsChallenge methodsChallenge = new MethodsChallenge();
            var response = methodsChallenge.FullNameMonth(4);

            //Assert
            Assert.Equal(value, response);


        }
    }
}
