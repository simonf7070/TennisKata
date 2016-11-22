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
            var scorer = new Scorer();
            PlayMatch(scorer, scoringSequence);
            Assert.That(scorer.Score.ToString(), Is.EqualTo(expected));
        }
        
        private static void PlayMatch(Scorer scorer, string scoringSequence)
        {
            foreach (var point in scoringSequence)
            {
                switch (point)
                {
                    case 'S':
                        scorer.ServerWonPoint();
                        break;
                    case 'R':
                        scorer.ReceiverWonPoint();
                        break;
                }
            }
        }
    }
}
