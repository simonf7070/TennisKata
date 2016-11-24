using Resources;

namespace TennisScoring.Game
{
    public class LoveAll : Score
    {
        public override string ToString() => GameScores.LoveAll;
        public override Score ServerScored() => new FifteenLove();
        public override Score ReceiverScored() => new LoveFifteen();
    }
    
    public class LoveFifteen : Score
    {
        public override string ToString() => GameScores.LoveFifteen;
        public override Score ServerScored() => new FifteenAll();
        public override Score ReceiverScored() => new LoveThirty();
    }

    public class LoveThirty : Score
    {
        public override string ToString() => GameScores.LoveThirty;
        public override Score ServerScored() => new FifteenThirty();
        public override Score ReceiverScored() => new LoveForty();
    }

    public class LoveForty : Score
    {
        public override string ToString() => GameScores.LoveForty;
        public override Score ServerScored() => new FifteenForty();
        public override Score ReceiverScored() => new GameToReceiver();
    }

    public class FifteenThirty : Score
    {
        public override string ToString() => GameScores.FifteenThirty;
        public override Score ServerScored() => new ThirtyAll();
        public override Score ReceiverScored() => new FifteenForty();
    }

    public class FifteenForty : Score
    {
        public override string ToString() => GameScores.FifteenForty;
        public override Score ServerScored() => new ThirtyForty();
        public override Score ReceiverScored() => new GameToReceiver();
    }

    public class ThirtyForty : Score
    {
        public override string ToString() => GameScores.ThirtyForty;
        public override Score ServerScored() => new Deuce();
        public override Score ReceiverScored() => new GameToReceiver();
    }

    public class Deuce : Score
    {
        public override string ToString() => GameScores.Deuce;
        public override Score ServerScored() => new AdvantageServer();
        public override Score ReceiverScored() => new AdvantageReceiver();
    }

    public class AdvantageReceiver : Score
    {
        public override string ToString() => GameScores.AdvantageReceiver;
        public override Score ServerScored() => new Deuce();
        public override Score ReceiverScored() => new GameToReceiver();
    }

    public class AdvantageServer : Score
    {
        public override string ToString() => GameScores.AdvantageServer;
        public override Score ServerScored() => new GameToServer();
        public override Score ReceiverScored() => new Deuce();
    }

    public class ThirtyAll : Score
    {
        public override string ToString() => GameScores.ThirtyAll;
        public override Score ServerScored() => new FortyThirty();
        public override Score ReceiverScored() => new ThirtyForty();
    }

    public class FortyThirty : Score
    {
        public override string ToString() => GameScores.FortyThirty;
        public override Score ServerScored() => new GameToReceiver();
        public override Score ReceiverScored() => new Deuce();
    }
    
    public class FifteenLove : Score
    {
        public override string ToString() => GameScores.FifteenLove;
        public override Score ServerScored() => new ThirtyLove();
        public override Score ReceiverScored() => new FifteenAll();
    }

    public class ThirtyLove : Score
    {
        public override string ToString() => GameScores.ThirtyLove;
        public override Score ServerScored() => new FortyLove();
        public override Score ReceiverScored() => new ThirtyFifteen();
    }

    public class ThirtyFifteen : Score
    {
        public override string ToString() => GameScores.ThirtyFifteen;
        public override Score ServerScored() => new FortyFifteen();
        public override Score ReceiverScored() => new ThirtyAll();
    }

    public class FortyFifteen : Score
    {
        public override string ToString() => GameScores.FortyFifteen;
        public override Score ServerScored() => new GameToReceiver();
        public override Score ReceiverScored() => new FortyThirty();
    }

    public class FortyLove : Score
    {
        public override string ToString() => GameScores.FortyLove;
        public override Score ServerScored() => new GameToServer();
        public override Score ReceiverScored() => new FortyFifteen();
    }

    public class FifteenAll : Score
    {
        public override string ToString() => GameScores.FifteenAll;
        public override Score ServerScored() => new ThirtyFifteen();
        public override Score ReceiverScored() => new FifteenThirty();
    }

    public class GameToServer : Score
    {
        public override string ToString() => GameScores.GameToServer;
        public override Score ServerScored() => this;
        public override Score ReceiverScored() => this;
    }

    public class GameToReceiver : Score
    {
        public override string ToString() => GameScores.GameToReceiver;
        public override Score ServerScored() => this;
        public override Score ReceiverScored() => this;
    }
}
