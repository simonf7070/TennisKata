namespace TennisScoring.Game
{
    public class LoveAll : Score
    {
        public override string ToString() => "Love all";
        public override Score ServerScored() => new FifteenLove();
        public override Score ReceiverScored() => new LoveFifteen();
    }
    
    public class LoveFifteen : Score
    {
        public override string ToString() => "Love 15";
        public override Score ServerScored() => new FifteenAll();
        public override Score ReceiverScored() => new LoveThirty();
    }

    public class LoveThirty : Score
    {
        public override string ToString() => "Love 30";
        public override Score ServerScored() => new FifteenThirty();
        public override Score ReceiverScored() => new LoveForty();
    }

    public class FifteenThirty : Score
    {
        public override string ToString() => "15 30";
        public override Score ServerScored() => new ThirtyAll();
        public override Score ReceiverScored() => new FifteenForty();
    }

    public class FifteenForty : Score
    {
        public override string ToString() => "15 40";
        public override Score ServerScored() => new ThirtyForty();
        public override Score ReceiverScored() => new ToReceiver();
    }

    public class ThirtyForty : Score
    {
        public override string ToString() => "30 40";
        public override Score ServerScored() => new Deuce();
        public override Score ReceiverScored() => new ToReceiver();
    }

    public class Deuce : Score
    {
        public override string ToString() => "Deuce";
        public override Score ServerScored() => new AdvantageServer();
        public override Score ReceiverScored() => new AdvantageReceiver();
    }

    public class AdvantageReceiver : Score
    {
        public override string ToString() => "Advantage receiver";
        public override Score ServerScored() => new Deuce();
        public override Score ReceiverScored() => new ToReceiver();
    }

    public class AdvantageServer : Score
    {
        public override string ToString() => "Advantage server";
        public override Score ServerScored() => new ToServer();
        public override Score ReceiverScored() => new Deuce();
    }

    public class ThirtyAll : Score
    {
        public override string ToString() => "30 all";
        public override Score ServerScored() => new FortyThirty();
        public override Score ReceiverScored() => new ThirtyForty();
    }

    public class FortyThirty : Score
    {
        public override string ToString() => "40 30";
        public override Score ServerScored() => new ToReceiver();
        public override Score ReceiverScored() => new Deuce();
    }

    public class LoveForty : Score
    {
        public override string ToString() => "Love 40";
        public override Score ServerScored() => new FifteenForty();
        public override Score ReceiverScored() => new ToReceiver();
    }

    public class FifteenLove : Score
    {
        public override string ToString() => "15 love";
        public override Score ServerScored() => new ThirtyLove();
        public override Score ReceiverScored() => new FifteenAll();
    }

    public class ThirtyLove : Score
    {
        public override string ToString() => "30 love";
        public override Score ServerScored() => new FortyLove();
        public override Score ReceiverScored() => new ThirtyFifteen();
    }

    public class ThirtyFifteen : Score
    {
        public override string ToString() => "30 15";
        public override Score ServerScored() => new FortyFifteen();
        public override Score ReceiverScored() => new ThirtyAll();
    }

    public class FortyFifteen : Score
    {
        public override string ToString() => "40 15";
        public override Score ServerScored() => new ToReceiver();
        public override Score ReceiverScored() => new FortyThirty();
    }

    public class FortyLove : Score
    {
        public override string ToString() => "40 love";
        public override Score ServerScored() => new ToServer();
        public override Score ReceiverScored() => new FortyFifteen();
    }

    public class FifteenAll : Score
    {
        public override string ToString() => "15 all";
        public override Score ServerScored() => new ThirtyFifteen();
        public override Score ReceiverScored() => new FifteenThirty();
    }

    public class ToServer : Score
    {
        public override string ToString() => "Game to server";
        public override Score ServerScored() => this;
        public override Score ReceiverScored() => this;
    }

    public class ToReceiver : Score
    {
        public override string ToString() => "Game to receiver";
        public override Score ServerScored() => this;
        public override Score ReceiverScored() => this;
    }
}
