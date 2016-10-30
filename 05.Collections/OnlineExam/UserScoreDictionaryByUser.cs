using System;
using System.Collections.Generic;

namespace OnlineExam
{
    public class UserScoreDictionaryByUser : IUserScores
    {
        Dictionary<string, UserScore> _participantResultsByUserName;

        public UserScoreDictionaryByUser(IEnumerable<UserScore> userScores)
        {
            throw new NotImplementedException();
            //todo: initialize _participantResultsByUserName
            // use the UserName as key
            // use the whole object as a value
        }

        public bool TryGetScore(string userName, out int score)
        {
            throw new NotImplementedException();
            //ParticipantResult participantResult;
            // todo: use TryGetValue to get the participant from the dictionary
            //if (success == false)
            //{
            //    score = -1;
            //    return false;
            //}
            //
            //score = participantResult.Score;
            //return true;
        }
    }
}