using NUnit.Framework;
using QuestionServiceWebApi;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi
{
    [TestFixture]
    public class QuestionRepositoryTests
    {
        [Test]
        public void ShouldGetExpectedQuestionnaire()
        {
            var questionRepository = new QuestionRepository();

            var questionnaire = questionRepository.GetQuestionnaire();

            Assert.That(questionnaire.QuestionnaireTitle, Is.EqualTo("Geography Questions"));
            Assert.That(questionnaire.QuestionList[0].Value, Is.EqualTo("What is the capital of Cuba?"));
            Assert.That(questionnaire.QuestionList[1].Value, Is.EqualTo("What is the capital of France?"));
            Assert.That(questionnaire.QuestionList[2].Value, Is.EqualTo("What is the capital of Poland?"));
            Assert.That(questionnaire.QuestionList[3].Value, Is.EqualTo("What is the capital of Germany?"));
        }
    }
}