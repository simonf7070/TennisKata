using System.Globalization;
using System.Threading;
using NUnit.Framework;
using TennisScoring.Game;

namespace TennisScoring.Tests
{
    [TestFixture]
    public class GameScoreI18NTests
    {
        [Test]
        public void PlayMatchWithWithCultureUIFrench_CurrentScoreShouldBeCorrect()
        {
            var score = new LoveAll();

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");

            Assert.That(score.ToString(), Is.EqualTo("Aimer tout"));
        }
    }
}
