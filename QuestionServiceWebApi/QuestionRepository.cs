using System.Collections.Generic;
using QuestionServiceWebApi.Interfaces;

namespace QuestionServiceWebApi
{
    public class QuestionRepository : IQuestionRepository
    {
        public Questionnaire GetQuestionnaire()
        {
            return new Questionnaire
            {
                QuestionnaireTitle = "Geography Questions",

                QuestionList = new List<Question>()
                {
                    new Question() { Value = "What is the capital of Cuba?", AnswerList = new List<string>() { "Havana" } },
                    new Question() { Value = "What is the capital of France?", AnswerList = new List<string>() { "Paris" } },
                    new Question() { Value = "What is the capital of Poland?", AnswerList = new List<string>() { "Warsaw" } },
                    new Question() { Value = "What is the capital of Germany?", AnswerList = new List<string>() { "Berlin" } }
                }
            };
        }
    }
}