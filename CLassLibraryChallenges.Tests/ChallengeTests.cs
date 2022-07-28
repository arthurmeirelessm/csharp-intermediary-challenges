using NUnit.Framework;
using System;

namespace CLassLibraryChallenges.Tests
{
    public class ChallengeTests
    {
        [TestFixture]

        public class MethodsChallenge
        {
            [Test]

            public void FullNameMonthTest()
            {
                var sut = new MethodsChallenge();

                var response = sut.FullNameMonth(4);


            }

        }

    }
}
