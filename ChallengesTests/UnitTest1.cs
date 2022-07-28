using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using csharp-intermediary - ChallengesTests;

namespace ChallengesTests
{
	[TestFixture]
    public class Tests
    {
		[Test]
		[TestCase(1, ExpectedResult = "January")]
		[TestCase(2, ExpectedResult = "February")]
		[TestCase(3, ExpectedResult = "March")]
		[TestCase(4, ExpectedResult = "April")]
		[TestCase(5, ExpectedResult = "May")]
		[TestCase(6, ExpectedResult = "June")]
		[TestCase(7, ExpectedResult = "July")]
		[TestCase(8, ExpectedResult = "August")]
		[TestCase(9, ExpectedResult = "September")]
		[TestCase(10, ExpectedResult = "October")]
		[TestCase(11, ExpectedResult = "November")]
		[TestCase(12, ExpectedResult = "December")]
		public static void MonthName(int num)
		{
		   
		    string response = MethodsChallenge
			
		}
	}
}