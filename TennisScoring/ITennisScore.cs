namespace TennisScoring
{
    public interface ITennisScore
    {
        string AsString();
        ITennisScore ServerScored();
        ITennisScore ReceiverScored();
    }
}