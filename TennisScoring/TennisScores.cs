namespace TennisScoring
{
    public class LoveAll : ITennisScore
    {
        public string AsString() => "Love all";
        public ITennisScore ServerScored() => new FifteenLove();
        public ITennisScore ReceiverScored() => new LoveFifteen();
    }

    public class LoveFifteen : ITennisScore
    {
        public string AsString() => "Love 15";
        public ITennisScore ServerScored() => new FifteenAll();
        public ITennisScore ReceiverScored() => new LoveThirty();
    }

    public class LoveThirty : ITennisScore
    {
        public string AsString() => "Love 30";
        public ITennisScore ServerScored() => new FifteenThirty();
        public ITennisScore ReceiverScored() => new LoveForty();
    }

    public class FifteenThirty : ITennisScore
    {
        public string AsString() => "15 30";
        public ITennisScore ServerScored() => new ThirtyAll();
        public ITennisScore ReceiverScored() => new FifteenForty();
    }

    public class FifteenForty : ITennisScore
    {
        public string AsString() => "15 40";
        public ITennisScore ServerScored() => new ThirtyForty();
        public ITennisScore ReceiverScored() => new GameToReceiver();
    }

    public class ThirtyForty : ITennisScore
    {
        public string AsString() => "30 40";
        public ITennisScore ServerScored() => new Deuce();
        public ITennisScore ReceiverScored() => new GameToReceiver();
    }

    public class Deuce : ITennisScore
    {
        public string AsString() => "Deuce";
        public ITennisScore ServerScored() => new AdvantageServer();
        public ITennisScore ReceiverScored() => new AdvantageReceiver();
    }

    public class AdvantageReceiver : ITennisScore
    {
        public string AsString() => "Advantage receiver";
        public ITennisScore ServerScored() => new Deuce();
        public ITennisScore ReceiverScored() => new GameToReceiver();
    }

    public class AdvantageServer : ITennisScore
    {
        public string AsString() => "Advantage server";
        public ITennisScore ServerScored() => new GameToServer();
        public ITennisScore ReceiverScored() => new Deuce();
    }

    public class ThirtyAll : ITennisScore
    {
        public string AsString() => "30 all";
        public ITennisScore ServerScored() => new FortyThirty();
        public ITennisScore ReceiverScored() => new ThirtyForty();
    }

    public class FortyThirty : ITennisScore
    {
        public string AsString() => "40 30";
        public ITennisScore ServerScored() => new GameToReceiver();
        public ITennisScore ReceiverScored() => new Deuce();
    }

    public class LoveForty : ITennisScore
    {
        public string AsString() => "Love 40";
        public ITennisScore ServerScored() => new FifteenForty();
        public ITennisScore ReceiverScored() => new GameToReceiver();
    }

    public class FifteenLove : ITennisScore
    {
        public string AsString() => "15 love";
        public ITennisScore ServerScored() => new ThirtyLove();
        public ITennisScore ReceiverScored() => new FifteenAll();
    }

    public class ThirtyLove : ITennisScore
    {
        public string AsString() => "30 love";
        public ITennisScore ServerScored() => new FortyLove();
        public ITennisScore ReceiverScored() => new ThirtyFifteen();
    }

    public class ThirtyFifteen : ITennisScore
    {
        public string AsString() => "30 15";
        public ITennisScore ServerScored() => new FortyFifteen();
        public ITennisScore ReceiverScored() => new ThirtyAll();
    }

    public class FortyFifteen : ITennisScore
    {
        public string AsString() => "40 15";
        public ITennisScore ServerScored() => new GameToReceiver();
        public ITennisScore ReceiverScored() => new FortyThirty();
    }

    public class FortyLove : ITennisScore
    {
        public string AsString() => "40 love";
        public ITennisScore ServerScored() => new GameToServer();
        public ITennisScore ReceiverScored() => new FortyFifteen();
    }

    public class FifteenAll : ITennisScore
    {
        public string AsString() => "15 all";
        public ITennisScore ServerScored() => new ThirtyFifteen();
        public ITennisScore ReceiverScored() => new FifteenThirty();
    }

    public class GameToServer : ITennisScore
    {
        public string AsString() => "Game to server";
        public ITennisScore ServerScored() => this;
        public ITennisScore ReceiverScored() => this;
    }

    public class GameToReceiver : ITennisScore
    {
        public string AsString() => "Game to receiver";
        public ITennisScore ServerScored() => this;
        public ITennisScore ReceiverScored() => this;
    }
}
