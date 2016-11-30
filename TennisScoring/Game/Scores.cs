using Resources;

namespace TennisScoring.Game
{
    public class LoveAll : IScore
    {
        public override string ToString() => GameScores.LoveAll;
        public IScore ServerScored() => new FifteenLove();
        public IScore ReceiverScored() => new LoveFifteen();
    }
    
    public class LoveFifteen : IScore
    {
        public override string ToString() => GameScores.LoveFifteen;
        public IScore ServerScored() => new FifteenAll();
        public IScore ReceiverScored() => new LoveThirty();
    }

    public class LoveThirty : IScore
    {
        public override string ToString() => GameScores.LoveThirty;
        public IScore ServerScored() => new FifteenThirty();
        public IScore ReceiverScored() => new LoveForty();
    }

    public class LoveForty : IScore
    {
        public override string ToString() => GameScores.LoveForty;
        public IScore ServerScored() => new FifteenForty();
        public IScore ReceiverScored() => new GameToReceiver();
    }

    public class FifteenThirty : IScore
    {
        public override string ToString() => GameScores.FifteenThirty;
        public IScore ServerScored() => new ThirtyAll();
        public IScore ReceiverScored() => new FifteenForty();
    }

    public class FifteenForty : IScore
    {
        public override string ToString() => GameScores.FifteenForty;
        public IScore ServerScored() => new ThirtyForty();
        public IScore ReceiverScored() => new GameToReceiver();
    }

    public class ThirtyForty : IScore
    {
        public override string ToString() => GameScores.ThirtyForty;
        public IScore ServerScored() => new Deuce();
        public IScore ReceiverScored() => new GameToReceiver();
    }

    public class Deuce : IScore
    {
        public override string ToString() => GameScores.Deuce;
        public IScore ServerScored() => new AdvantageServer();
        public IScore ReceiverScored() => new AdvantageReceiver();
    }

    public class AdvantageReceiver : IScore
    {
        public override string ToString() => GameScores.AdvantageReceiver;
        public IScore ServerScored() => new Deuce();
        public IScore ReceiverScored() => new GameToReceiver();
    }

    public class AdvantageServer : IScore
    {
        public override string ToString() => GameScores.AdvantageServer;
        public IScore ServerScored() => new GameToServer();
        public IScore ReceiverScored() => new Deuce();
    }

    public class ThirtyAll : IScore
    {
        public override string ToString() => GameScores.ThirtyAll;
        public IScore ServerScored() => new FortyThirty();
        public IScore ReceiverScored() => new ThirtyForty();
    }

    public class FortyThirty : IScore
    {
        public override string ToString() => GameScores.FortyThirty;
        public IScore ServerScored() => new GameToServer();
        public IScore ReceiverScored() => new Deuce();
    }
    
    public class FifteenLove : IScore
    {
        public override string ToString() => GameScores.FifteenLove;
        public IScore ServerScored() => new ThirtyLove();
        public IScore ReceiverScored() => new FifteenAll();
    }

    public class ThirtyLove : IScore
    {
        public override string ToString() => GameScores.ThirtyLove;
        public IScore ServerScored() => new FortyLove();
        public IScore ReceiverScored() => new ThirtyFifteen();
    }

    public class ThirtyFifteen : IScore
    {
        public override string ToString() => GameScores.ThirtyFifteen;
        public IScore ServerScored() => new FortyFifteen();
        public IScore ReceiverScored() => new ThirtyAll();
    }

    public class FortyFifteen : IScore
    {
        public override string ToString() => GameScores.FortyFifteen;
        public IScore ServerScored() => new GameToServer();
        public IScore ReceiverScored() => new FortyThirty();
    }

    public class FortyLove : IScore
    {
        public override string ToString() => GameScores.FortyLove;
        public IScore ServerScored() => new GameToServer();
        public IScore ReceiverScored() => new FortyFifteen();
    }

    public class FifteenAll : IScore
    {
        public override string ToString() => GameScores.FifteenAll;
        public IScore ServerScored() => new ThirtyFifteen();
        public IScore ReceiverScored() => new FifteenThirty();
    }

    public class GameToServer : IScore
    {
        public override string ToString() => GameScores.GameToServer;
        public IScore ServerScored() => this;
        public IScore ReceiverScored() => this;
    }

    public class GameToReceiver : IScore
    {
        public override string ToString() => GameScores.GameToReceiver;
        public IScore ServerScored() => this;
        public IScore ReceiverScored() => this;
    }
}
