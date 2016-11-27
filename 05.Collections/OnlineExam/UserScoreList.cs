using System;
using System.Collections.Generic;

namespace OnlineExam
{
    public class UserScoreList : IUserScores
    {
        List<UserScore> _participantResults;

        public UserScoreList(IEnumerable<UserScore> userScores)
        {
            // initialize _participantResults
            _participantResults = new List<UserScore>();
            foreach(var userScore in userScores)
            {
                _participantResults.Add(userScore);
            }
        }

        public bool TryGetScore(string userName, out int score)
        {
            foreach (var p in _participantResults)
            {
                if (p.UserName == userName)
                {
                    score = p.Score;
                    return true;
                }
            }
            score = -1;
            return false;
        }
    }
}