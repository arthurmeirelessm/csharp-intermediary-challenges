using csharp_intermediary_challenges;
using System;
using Xunit;

namespace ChallengesTest
{
    public class ChallengeTests
    {

        //(1)
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
         
        //(1)
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

        //(2)
        [Fact] 

        public void FindMinMaxTestSuccess()
        {
            //Arrange
            var valueOfarray = new int[] {4 , 6 , 5, 5, 6, 3, 3, 6};
            var expected = true;

            //Act
            MethodsChallenge methodChallenge = new MethodsChallenge();
            var response = methodChallenge.FindMinMax(valueOfarray);

            //Assert
            Assert.Equal(expected, response);
        }

        [Fact]

        public void FindMinMaxTestFail()
        {
            //Arrange
            var valueOfarray = new int[] { 4 };
            var expected = false;

            //Act
            MethodsChallenge methodsChallenge = new MethodsChallenge();
            var response = methodsChallenge.FindMinMax(valueOfarray);

            //Assert
            Assert.Equal(expected, response);
        }
    }
}
