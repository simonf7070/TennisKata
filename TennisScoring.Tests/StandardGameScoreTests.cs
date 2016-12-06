using NUnit.Framework;
using TennisScoring.Game;

namespace TennisScoring.Tests
{
    [TestFixture]
    public class StandardGameScoreTests
    {
        [TestCaseSource(nameof(ServerScored))]
        public void WhenServerWinsNextPointScoreIsExpectedScore(IScore currentScore, IScore expectedScore)
        {
            var newScore = currentScore.ServerScored();
            Assert.That(newScore, Is.InstanceOf(expectedScore.GetType()));
        }

        [TestCaseSource(nameof(ReceiverScored))]
        public void WhenReceiverWinsNextPointScoreIsExpectedScore(IScore currentScore, IScore expectedScore)
        {
            var newScore = currentScore.ReceiverScored();
            Assert.That(newScore, Is.InstanceOf(expectedScore.GetType()));
        }

        private static readonly object[] ServerScored =
        {
            new object[] { new LoveAll(), new FifteenLove() },
            new object[] { new LoveFifteen(), new FifteenAll() },
            new object[] { new LoveThirty(), new FifteenThirty() },
            new object[] { new LoveForty(), new FifteenForty() },
            new object[] { new FifteenLove(), new ThirtyLove() },
            new object[] { new FifteenAll(), new ThirtyFifteen() },
            new object[] { new FifteenThirty(), new ThirtyAll() },
            new object[] { new FifteenForty(), new ThirtyForty() },
            new object[] { new ThirtyLove(), new FortyLove() },
            new object[] { new ThirtyFifteen(), new FortyFifteen() },
            new object[] { new ThirtyAll(), new FortyThirty() },
            new object[] { new ThirtyForty(), new Deuce() },
            new object[] { new FortyLove(), new GameToServer() },
            new object[] { new FortyFifteen(), new GameToServer() },
            new object[] { new FortyThirty(), new GameToServer() },
            new object[] { new Deuce(), new AdvantageServer() },
            new object[] { new AdvantageServer(), new GameToServer() },
            new object[] { new AdvantageReceiver(), new Deuce() },
            new object[] { new GameToServer(), new GameToServer() },
            new object[] { new GameToReceiver(), new GameToReceiver() }
        };

        private static readonly object[] ReceiverScored =
        {
            new object[] { new LoveAll(), new LoveFifteen() },
            new object[] { new LoveFifteen(), new LoveThirty() },
            new object[] { new LoveThirty(), new LoveForty() },
            new object[] { new LoveForty(), new GameToReceiver() },
            new object[] { new FifteenLove(), new FifteenAll() },
            new object[] { new FifteenAll(), new FifteenThirty() },
            new object[] { new FifteenThirty(), new FifteenForty() },
            new object[] { new FifteenForty(), new GameToReceiver() },
            new object[] { new ThirtyLove(), new ThirtyFifteen() },
            new object[] { new ThirtyFifteen(), new ThirtyAll() },
            new object[] { new ThirtyAll(), new ThirtyForty() },
            new object[] { new ThirtyForty(), new GameToReceiver() },
            new object[] { new FortyLove(), new FortyFifteen() },
            new object[] { new FortyFifteen(), new FortyThirty() },
            new object[] { new FortyThirty(), new Deuce() },
            new object[] { new Deuce(), new AdvantageReceiver() },
            new object[] { new AdvantageReceiver(), new GameToReceiver() },
            new object[] { new AdvantageServer(), new Deuce() },
            new object[] { new GameToServer(), new GameToServer() },
            new object[] { new GameToReceiver(), new GameToReceiver() }
        };
    }
}
