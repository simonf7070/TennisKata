namespace TennisScoring.Game
{
    public class Scorer
    {
        public Score Score { get; private set; }

        public Scorer()
        {
            Score = new LoveAll();
        }

        public void ServerWonPoint()
        {
            Score = Score.ServerScored();
        }

        public void ReceiverWonPoint()
        {
            Score = Score.ReceiverScored();
        }
    }
}
