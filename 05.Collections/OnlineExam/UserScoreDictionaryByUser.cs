using System.Collections.Generic;

namespace OnlineExam
{
    public class UserScoreDictionaryByUser : IUserScores
    {
        private UserScore participantResult;
        Dictionary<string, UserScore> _participantResultsByUserName;

        public UserScoreDictionaryByUser(IEnumerable<UserScore> userScores)
        {
            _participantResultsByUserName = new Dictionary<string, UserScore>();
            foreach (UserScore userScore in userScores)
            {
                _participantResultsByUserName.Add(userScore.UserName, userScore);
            }
        }

        public bool TryGetScore(string userName, out int score)
        {
            bool success = _participantResultsByUserName.ContainsKey(userName);
            if (success == false)
            {
                score = -1;
                return false;
            }
            else
            {
                participantResult = _participantResultsByUserName[userName];
            }
            score = participantResult.Score;
            return true;
        }
    }
}