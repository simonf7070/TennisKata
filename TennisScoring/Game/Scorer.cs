namespace TennisScoring.Game
{
    public class Scorer
    {
        private Score _score;
        
        public Scorer()
        {
            _score = new LoveAll();
        }

        public void ServerWonPoint()
        {
            _score = _score.ServerScored();
        }

        public void ReceiverWonPoint()
        {
            _score = _score.ReceiverScored();
        }

        public override string ToString() => _score.ToString();
    }
}
