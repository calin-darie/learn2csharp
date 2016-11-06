namespace OnlineExam
{
    public interface IUserScores
    {
        bool TryGetScore(string userName, out int score);
    }
}