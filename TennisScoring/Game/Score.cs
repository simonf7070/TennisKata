namespace TennisScoring.Game
{
    public interface IScore
    {
        IScore ServerScored();
        IScore ReceiverScored();
    }
}