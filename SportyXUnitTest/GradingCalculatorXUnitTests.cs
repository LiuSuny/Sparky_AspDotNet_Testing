
using Sporty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SportyXUnitTest
{
   
    public class GradingCalculatorXUnitTests
    {
        private GradingCalculator gradingCalculator;

        public GradingCalculatorXUnitTests()
        {
            gradingCalculator = new GradingCalculator();
        }

        //        [Test]
        //        public void GradeCalc_InputScore95Attendance90_GetAGrade()
        //        {
        //            gradingCalculator.Score = 95;
        //            gradingCalculator.AttendancePercentage = 90;
        //            string result = gradingCalculator.GetGrade();
        //            Assert.That(result, Is.EqualTo("A"));
        //        }
        [Fact]
        public void GradeCalc_InputScore95Attendance90_GetAGrade()
        {
            gradingCalculator.Score = 95;
            gradingCalculator.AttendancePercentage = 90;
            string result = gradingCalculator.GetGrade();
            Assert.Equal("A", result);
        }

        //        [Test]
        //        public void GradeCalc_InputScore85Attendance90_GetBGrade()
        //        {
        //            gradingCalculator.Score = 85;
        //            gradingCalculator.AttendancePercentage = 90;
        //            string result = gradingCalculator.GetGrade();
        //            Assert.That(result, Is.EqualTo("B"));
        //        }
        [Fact]
        public void GradeCalc_InputScore85Attendance90_GetBGrade()
        {
            gradingCalculator.Score = 85;
            gradingCalculator.AttendancePercentage = 90;
            string result = gradingCalculator.GetGrade();
            Assert.Equal("B", result);
        }

        //        [Test]
        //        public void GradeCalc_InputScore65Attendance90_GetCGrade()
        //        {
        //            gradingCalculator.Score = 65;
        //            gradingCalculator.AttendancePercentage = 90;
        //            string result = gradingCalculator.GetGrade();
        //            Assert.That(result, Is.EqualTo("C"));
        //        }
        [Fact]
        public void GradeCalc_InputScore65Attendance90_GetCGrade()
        {
            gradingCalculator.Score = 65;
            gradingCalculator.AttendancePercentage = 90;
            string result = gradingCalculator.GetGrade();
            Assert.Equal("C", result);
        }

        //        [Test]
        //        public void GradeCalc_InputScore95Attendance65_GetBGrade()
        //        {
        //            gradingCalculator.Score = 95;
        //            gradingCalculator.AttendancePercentage = 65;
        //            string result = gradingCalculator.GetGrade();
        //            Assert.That(result, Is.EqualTo("B"));
        //        }
        [Fact]
        public void GradeCalc_InputScore95Attendance65_GetBGrade()
        {
            gradingCalculator.Score = 95;
            gradingCalculator.AttendancePercentage = 65;
            string result = gradingCalculator.GetGrade();
            Assert.Equal("B", result);
        }

        //        [Test]
        //        [TestCase(95,55)]
        //        [TestCase(65, 55)]
        //        [TestCase(50, 90)]
        //        public void GradeCalc_FailsureScenarios_GetFGrade(int score, int attendance)
        //        {
        //            gradingCalculator.Score = score;
        //            gradingCalculator.AttendancePercentage = attendance;
        //            string result = gradingCalculator.GetGrade();
        //            Assert.That(result, Is.EqualTo("F"));
        //        }
        [Theory]
        [InlineData(95, 55)]
        [InlineData(65, 55)]
        [InlineData(50, 90)]
        public void GradeCalc_FailsureScenarios_GetFGrade(int score, int attendance)
        {
            gradingCalculator.Score = score;
            gradingCalculator.AttendancePercentage = attendance;
            string result = gradingCalculator.GetGrade();
            Assert.Equal("F", result);
        }

        //        [Test]
        //        [TestCase(95, 90, ExpectedResult = "A")]
        //        [TestCase(85, 90, ExpectedResult = "B")]
        //        [TestCase(65, 90, ExpectedResult = "C")]
        //        [TestCase(95, 65, ExpectedResult = "B")]
        //        [TestCase(95, 55, ExpectedResult = "F")]
        //        [TestCase(65, 55, ExpectedResult = "F")]
        //        [TestCase(50, 90, ExpectedResult = "F")]
        [Theory]
        [InlineData(95, 90, "A")]
        [InlineData(85, 90, "B")]
        [InlineData(65, 90, "C")]
        [InlineData(95, 65, "B")]
        [InlineData(95, 55, "F")]
        [InlineData(65, 55, "F")]
        [InlineData(50, 90, "F")]

        //        public string GradeCalc_AllGradeLogicalScenarios_GradeOutput(int score, int attendance)
        //        {
        //            gradingCalculator.Score = score;
        //            gradingCalculator.AttendancePercentage = attendance;
        //            return gradingCalculator.GetGrade();
        //        }
        //    }
        //}
        public void GradeCalc_AllGradeLogicalScenarios_GradeOutput(int score, int attendance, string expectedResult)
        {
            gradingCalculator.Score = score;
            gradingCalculator.AttendancePercentage = attendance;
            var result = gradingCalculator.GetGrade();
            Assert.Equal(expectedResult, result);
        }
    }
}
