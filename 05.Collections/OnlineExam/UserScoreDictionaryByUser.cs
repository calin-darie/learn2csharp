using System;
using System.Collections.Generic;

namespace OnlineExam
{
    public class UserScoreDictionaryByUser : IUserScores
    {
        Dictionary<string, UserScore> _participantResultsByUserName;

        public UserScoreDictionaryByUser(IEnumerable<UserScore> userScores)
        {
            // initialize _participantResultsByUserName
            _participantResultsByUserName = new Dictionary<string, UserScore>();
            foreach (var userScore in userScores)
            {
                _participantResultsByUserName.Add(userScore.UserName, userScore);
            }
        }

        public bool TryGetScore(string userName, out int score)
        {
            try
            {
                score = _participantResultsByUserName[userName].Score;
                return true;
            }
            catch(System.Collections.Generic.KeyNotFoundException)
            {
                score = -1;
                return false;
            }        
        }
    }
}