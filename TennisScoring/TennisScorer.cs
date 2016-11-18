namespace TennisScoring
{
    public class TennisScorer
    {
        public ITennisScore Score { get; private set; }

        public TennisScorer()
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
