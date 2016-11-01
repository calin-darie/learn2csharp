using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OnlineExam.UnitTests
{
    [TestClass]
    public class PerformanceTests
    {
        [TestMethod]
        public void ListVsDictionary_ManyEntriesAndManyQueriesByDictionaryKey_DictionaryPerformsBetter()
        {
            var participantCount = 3000;
            var queryCount = 100000;
            var participantResults = new UserScore[participantCount];
            for (int i = 0; i < participantCount; i++)
            {
                participantResults[i] = GenerateParticipantResult();
            }

            List<string> userNames = new List<string>();
            foreach (var pr in participantResults)
            {
                userNames.Add(pr.UserName);
            }

            var participantResultList = new UserScoreList(participantResults);
            var participantResultDictionaryByUser = new UserScoreDictionaryByUser(participantResults);

            var millisecondsList = TimeQueriesMilliseconds(userNames,
                participantResultList, queryCount);
            var millisecondsDictionary = TimeQueriesMilliseconds(userNames,
                participantResultDictionaryByUser, queryCount);

            Console.WriteLine("list: {0}ms vs dictionary: {1}ms", millisecondsList, millisecondsDictionary);
            //todo: check the output of the test and write the times below, in a comment

            Assert.IsTrue(millisecondsDictionary <= millisecondsList);
        }

        //todo: extract a method so that you can test with various participant counts and query counts:
        //[TestMethod]
        //public void ListVsDictionary_FewEntriesAndManyQueriesByDictionaryKey_DictionaryPerformsBetter()
        //{
        //    ListVsDictionary_DictionaryPerformsBetter(participantCount: 50, queryCount: 100000);
        //}
        //[TestMethod]
        //public void ListVsDictionary_ManyEntriesAndFewQueriesByDictionaryKey_DictionaryPerformsBetter()
        //{
        //    ListVsDictionary_DictionaryPerformsBetter(participantCount: 5000, queryCount: 50);
        //}
        //[TestMethod]
        //public void ListVsDictionary_FewEntriesAndFewQueriesByDictionaryKey_DictionaryPerformsBetter()
        //{
        //    ListVsDictionary_DictionaryPerformsBetter(participantCount: 50, queryCount: 50);
        //}

        long TimeQueriesMilliseconds(
            List<string> userNames,
            IUserScores participantResultList, 
            int queryCount)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < queryCount; i++)
            {
                var userName = RandomUserSearchingForHisScore(userNames);
                int score;
                participantResultList.TryGetScore(userName, out score);
            }
            stopwatch.Stop();
            var milliseconds = stopwatch.ElapsedMilliseconds;
            return milliseconds;
        }

        string RandomUserSearchingForHisScore(List<string> userNames)
        {
            var index = _random.Next(userNames.Count);
            return userNames[index];
        }
        
        public PerformanceTests()
        {
            var fixedSeedForRepeatableTests = 789798;
            _random = new Random(fixedSeedForRepeatableTests);
        }

        Random _random;
        static int _uniqueUserNameSuffix = 0;

        UserScore GenerateParticipantResult()
        {
            var userScore = new UserScore
            {
                UserName = "user" + (_uniqueUserNameSuffix++),
                Score = _random.Next(0, 100)
            };
            return userScore;
        }
    }
}
