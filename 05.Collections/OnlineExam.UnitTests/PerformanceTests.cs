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
            var results = ListVsDictionary_DictionaryPerformsBetter(participantCount: 3000, queryCount: 100000);
            var millisecondsList = results.Item1;
            var millisecondsDictionary = results.Item2;

            Console.WriteLine("list: {0}ms vs dictionary: {1}ms", millisecondsList, millisecondsDictionary);
            //Result StandardOutput: list: 2763ms vs dictionary: 15ms

            Assert.IsTrue(millisecondsDictionary <= millisecondsList);
        }

        [TestMethod]
        public void ListVsDictionary_FewEntriesAndManyQueriesByDictionaryKey_DictionaryPerformsBetter()
        {
            var results = ListVsDictionary_DictionaryPerformsBetter(participantCount: 50, queryCount: 100000);
            var millisecondsList = results.Item1;
            var millisecondsDictionary = results.Item2;

            Console.WriteLine("list: {0}ms vs dictionary: {1}ms", millisecondsList, millisecondsDictionary);
            //Result StandardOutput: list: 59ms vs dictionary: 13ms

            Assert.IsTrue(millisecondsDictionary <= millisecondsList);
        }
        [TestMethod]
        public void ListVsDictionary_ManyEntriesAndFewQueriesByDictionaryKey_DictionaryPerformsBetter()
        {
            var results = ListVsDictionary_DictionaryPerformsBetter(participantCount: 5000, queryCount: 50);
            var millisecondsList = results.Item1;
            var millisecondsDictionary = results.Item2;

            Console.WriteLine("list: {0}ms vs dictionary: {1}ms", millisecondsList, millisecondsDictionary);
            //Result StandardOutput: list: 2ms vs dictionary: 0ms

            Assert.IsTrue(millisecondsDictionary <= millisecondsList);
        }
        [TestMethod]
        public void ListVsDictionary_FewEntriesAndFewQueriesByDictionaryKey_DictionaryPerformsBetter()
        {
            var results = ListVsDictionary_DictionaryPerformsBetter(participantCount: 50, queryCount: 50);
            var millisecondsList = results.Item1;
            var millisecondsDictionary = results.Item2;

            Console.WriteLine("list: {0}ms vs dictionary: {1}ms", millisecondsList, millisecondsDictionary);
            //Result StandardOutput: list: 0ms vs dictionary: 0ms

            Assert.IsTrue(millisecondsDictionary <= millisecondsList);
        }

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

        public Tuple<double, double> ListVsDictionary_DictionaryPerformsBetter(int participantCount, int queryCount)
        {
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

            var results = new Tuple<double, double>(millisecondsList, millisecondsDictionary);
            return results;
        }
    }
}
