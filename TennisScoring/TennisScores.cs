namespace TennisScoring
{
    public class LoveAll : TennisScore
    {
        public override string ToString() => "Love all";
        public override TennisScore ServerScored() => new FifteenLove();
        public override TennisScore ReceiverScored() => new LoveFifteen();
    }
    
    public class LoveFifteen : TennisScore
    {
        public override string ToString() => "Love 15";
        public override TennisScore ServerScored() => new FifteenAll();
        public override TennisScore ReceiverScored() => new LoveThirty();
    }

    public class LoveThirty : TennisScore
    {
        public override string ToString() => "Love 30";
        public override TennisScore ServerScored() => new FifteenThirty();
        public override TennisScore ReceiverScored() => new LoveForty();
    }

    public class FifteenThirty : TennisScore
    {
        public override string ToString() => "15 30";
        public override TennisScore ServerScored() => new ThirtyAll();
        public override TennisScore ReceiverScored() => new FifteenForty();
    }

    public class FifteenForty : TennisScore
    {
        public override string ToString() => "15 40";
        public override TennisScore ServerScored() => new ThirtyForty();
        public override TennisScore ReceiverScored() => new GameToReceiver();
    }

    public class ThirtyForty : TennisScore
    {
        public override string ToString() => "30 40";
        public override TennisScore ServerScored() => new Deuce();
        public override TennisScore ReceiverScored() => new GameToReceiver();
    }

    public class Deuce : TennisScore
    {
        public override string ToString() => "Deuce";
        public override TennisScore ServerScored() => new AdvantageServer();
        public override TennisScore ReceiverScored() => new AdvantageReceiver();
    }

    public class AdvantageReceiver : TennisScore
    {
        public override string ToString() => "Advantage receiver";
        public override TennisScore ServerScored() => new Deuce();
        public override TennisScore ReceiverScored() => new GameToReceiver();
    }

    public class AdvantageServer : TennisScore
    {
        public override string ToString() => "Advantage server";
        public override TennisScore ServerScored() => new GameToServer();
        public override TennisScore ReceiverScored() => new Deuce();
    }

    public class ThirtyAll : TennisScore
    {
        public override string ToString() => "30 all";
        public override TennisScore ServerScored() => new FortyThirty();
        public override TennisScore ReceiverScored() => new ThirtyForty();
    }

    public class FortyThirty : TennisScore
    {
        public override string ToString() => "40 30";
        public override TennisScore ServerScored() => new GameToReceiver();
        public override TennisScore ReceiverScored() => new Deuce();
    }

    public class LoveForty : TennisScore
    {
        public override string ToString() => "Love 40";
        public override TennisScore ServerScored() => new FifteenForty();
        public override TennisScore ReceiverScored() => new GameToReceiver();
    }

    public class FifteenLove : TennisScore
    {
        public override string ToString() => "15 love";
        public override TennisScore ServerScored() => new ThirtyLove();
        public override TennisScore ReceiverScored() => new FifteenAll();
    }

    public class ThirtyLove : TennisScore
    {
        public override string ToString() => "30 love";
        public override TennisScore ServerScored() => new FortyLove();
        public override TennisScore ReceiverScored() => new ThirtyFifteen();
    }

    public class ThirtyFifteen : TennisScore
    {
        public override string ToString() => "30 15";
        public override TennisScore ServerScored() => new FortyFifteen();
        public override TennisScore ReceiverScored() => new ThirtyAll();
    }

    public class FortyFifteen : TennisScore
    {
        public override string ToString() => "40 15";
        public override TennisScore ServerScored() => new GameToReceiver();
        public override TennisScore ReceiverScored() => new FortyThirty();
    }

    public class FortyLove : TennisScore
    {
        public override string ToString() => "40 love";
        public override TennisScore ServerScored() => new GameToServer();
        public override TennisScore ReceiverScored() => new FortyFifteen();
    }

    public class FifteenAll : TennisScore
    {
        public override string ToString() => "15 all";
        public override TennisScore ServerScored() => new ThirtyFifteen();
        public override TennisScore ReceiverScored() => new FifteenThirty();
    }

    public class GameToServer : TennisScore
    {
        public override string ToString() => "Game to server";
        public override TennisScore ServerScored() => this;
        public override TennisScore ReceiverScored() => this;
    }

    public class GameToReceiver : TennisScore
    {
        public override string ToString() => "Game to receiver";
        public override TennisScore ServerScored() => this;
        public override TennisScore ReceiverScored() => this;
    }
}
