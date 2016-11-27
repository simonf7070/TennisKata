using NUnit.Framework;
using TennisScoring.Game;

namespace TennisScoring.Tests
{
    [TestFixture]
    public class GameScorerTests
    {
        [TestCase("", "Love all")]
        [TestCase("S", "15 love")]
        [TestCase("SR", "15 all")]
        [TestCase("SRR", "15 30")]
        [TestCase("SS", "30 love")]
        [TestCase("SSR", "30 15")]
        [TestCase("SSS", "40 love")]
        [TestCase("SSSS", "Game to server")]
        [TestCase("R", "Love 15")]
        [TestCase("RR", "Love 30")]
        [TestCase("RRR", "Love 40")]
        [TestCase("RRRR", "Game to receiver")]
        [TestCase("RRS", "15 30")]
        [TestCase("SRSR", "30 all")]
        [TestCase("SRSRSR", "Deuce")]
        [TestCase("SRSRSRS", "Advantage server")]
        [TestCase("RSRSRSR", "Advantage receiver")]
        [TestCase("RRRSSSRSRSRR", "Game to receiver")]
        [TestCase("SSSSRR", "Game to server")]
        [TestCase("RRRRSS", "Game to receiver")]
        public void PlayMatch_CurrentScoreShouldBeCorrect(string scoringSequence, string expected)
        {
            var gameScorer = new Scorer();
            PlayMatch(gameScorer, scoringSequence);
            Assert.That(gameScorer.ToString(), Is.EqualTo(expected));
        }
        
        private static void PlayMatch(Scorer gameScorer, string scoringSequence)
        {
            foreach (var point in scoringSequence)
            {
                switch (point)
                {
                    case 'S':
                        gameScorer.ServerWonPoint();
                        break;
                    case 'R':
                        gameScorer.ReceiverWonPoint();
                        break;
                }
            }
        }

        [Test]
        public void CurrentScoreShouldBeCorrect()
        {
            var score = new LoveAll().ServerScored().ReceiverScored().ReceiverScored().ReceiverScored().ReceiverScored();
            Assert.That(score, Is.TypeOf<GameToReceiver>());
        }

        [Test]
        public void WhenScoreIsFifteenFortyAndReceiverWinsTheNextPointThenShouldBeGameToReceiver()
        {
            var currentScore = new FifteenForty();
            var newScore = currentScore.ReceiverScored();
            Assert.That(newScore, Is.TypeOf<GameToReceiver>());
        }

        [TestCaseSource(nameof(ReceiverScores))]
        public void WhenReceiverWinsNextPointScoreIsExpectedScore(Score currentScore, Score expectedScore)
        {
            var newScore = currentScore.ReceiverScored();
            Assert.IsInstanceOf(expectedScore.GetType(), newScore);
        }

        static object[] ReceiverScores =
        {
            new object[] { new LoveAll(), new LoveFifteen() },
            new object[] { new LoveFifteen(), new LoveThirty() },
            new object[] { new LoveThirty(), new LoveForty() },
            new object[] { new LoveForty(), new GameToReceiver() },
            new object[] { new FifteenAll(), new FifteenThirty() },
            new object[] { new FifteenThirty(), new FifteenForty() },
            new object[] { new FifteenForty(), new GameToReceiver() },
            new object[] { new ThirtyAll(), new ThirtyForty() },
            new object[] { new ThirtyForty(), new GameToReceiver() },
            new object[] { new Deuce(), new AdvantageReceiver() },
            new object[] { new AdvantageReceiver(), new GameToReceiver() },
            new object[] { new AdvantageServer(), new Deuce() },
        };

        [TestCaseSource(nameof(ServerScores))]
        public void WhenServerWinsNextPointScoreIsExpectedScore(Score currentScore, Score expectedScore)
        {
            var newScore = currentScore.ServerScored();
            Assert.IsInstanceOf(expectedScore.GetType(), newScore);
        }

        static object[] ServerScores =
        {
            new object[] { new LoveAll(), new FifteenLove() },
            new object[] { new FifteenLove(), new ThirtyLove() },
            new object[] { new ThirtyLove(), new FortyLove() },
            new object[] { new FortyLove(), new GameToServer() },
            new object[] { new FifteenAll(), new ThirtyFifteen() },
            new object[] { new ThirtyFifteen(), new FortyFifteen() },
            new object[] { new FortyFifteen(), new GameToServer() },
            new object[] { new ThirtyAll(), new FortyThirty() },
            new object[] { new FortyThirty(), new GameToServer() },
            new object[] { new Deuce(), new AdvantageServer() },
            new object[] { new AdvantageServer(), new GameToServer() },
            new object[] { new AdvantageReceiver(), new Deuce() },
        };
    }
}
