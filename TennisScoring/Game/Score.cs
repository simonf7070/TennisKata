namespace TennisScoring.Game
{
    public abstract class Score
    {
        public abstract override string ToString();
        public abstract Score ServerScored();
        public abstract Score ReceiverScored();
    }
}