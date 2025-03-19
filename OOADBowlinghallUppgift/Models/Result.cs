namespace OOADBowlinghallUppgift.Models
{
    public class Result // lagrar poängen o styr vinnare i determine metoden
    {
        public Player Player1 { get; set; }
        public int Score1 { get; set; }
        public Player Player2 { get; set; }
        public int Score2 { get; set; }
        public Player? Winner { get; private set; } 

        public Result(Player player1, int score1, Player player2, int score2)
        {
            Player1 = player1;
            Score1 = score1;
            Player2 = player2;
            Score2 = score2;

            DetermineWinner();
        }

        private void DetermineWinner()
        {
            if (Score1 > Score2)
                Winner = Player1;
            else if (Score2 > Score1)
                Winner = Player2;
            else
                Winner = null; // Oavgjort
        }
    }
}
