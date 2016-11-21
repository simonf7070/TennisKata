namespace TennisScoring
{
    public abstract class TennisScore
    {
        public abstract override string ToString();
        public abstract TennisScore ServerScored();
        public abstract TennisScore ReceiverScored();
    }
}