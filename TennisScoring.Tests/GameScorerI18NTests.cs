using System.Globalization;
using System.Threading;
using NUnit.Framework;
using TennisScoring.Game;

namespace TennisScoring.Tests
{
    [TestFixture]
    public class GameScorerI18NTests
    {
        [Test]
        public void PlayMatchWithWithCultureUIFrench_CurrentScoreShouldBeCorrect()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            var gameScorer = new Scorer();
            Assert.That(gameScorer.ToString(), Is.EqualTo("Aimer tout"));
        }
    }
}
