using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OnlineExam.UnitTests
{
    public abstract class UserScoresTests
    {
        [TestMethod]
        public void GivenSingleUserScore_TryGetScore_OutputsTheScore()
        {
            var score = 51;
            var user = "john.doe51";
            var userScores = new[]
            {
                new UserScore
                {
                    UserName = "jane.doe42",
                    Score = 99
                },
                new UserScore
                {
                    UserName = user,
                    Score = score
                },
            };
            var systemUnderTest = CreateSystemUnderTest(userScores);

            int outputScore;
            var success = systemUnderTest.TryGetScore(user, out outputScore);

            Assert.IsTrue(success);
            Assert.AreEqual(score, outputScore);
        }

        [TestMethod]
        public void GivenWrongUser_TryGetScore_ReturnsFalse()
        {
            var userScores = new[]
            {
                new UserScore
                {
                    UserName = "jane.doe42",
                    Score = 99
                },
                new UserScore
                {
                    UserName = "john.doe51",
                    Score = 80
                },
            };
            var systemUnderTest = CreateSystemUnderTest(userScores);

            int returnedScore;
            var success = systemUnderTest.TryGetScore("huhulescu.constantin", out returnedScore);

            Assert.IsFalse(success);
        }


        //todo: write test for no scores.

        protected abstract IUserScores CreateSystemUnderTest(UserScore[] scores);
    }

    [TestClass]
    public class UserScoreListTests : UserScoresTests
    {
        protected override IUserScores CreateSystemUnderTest(UserScore[] scores)
        {
            return new UserScoreList(scores);
        }
    }

    [TestClass]
    public class UserScoreDictionaryByUserTests : UserScoresTests
    {
        protected override IUserScores CreateSystemUnderTest(UserScore[] scores)
        {
            return new UserScoreDictionaryByUser(scores);
        }
    }
}