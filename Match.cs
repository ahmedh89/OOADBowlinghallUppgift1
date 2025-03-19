namespace OOADBowlinghallUppgift.Models
{
    public class Match
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Result? MatchResult { get; private set; } // Null-säker hantering

        public Match(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public void RegisterResult(int score1, int score2)
        {
            MatchResult = new Result(Player1, score1, Player2, score2);
        }
    }
}
