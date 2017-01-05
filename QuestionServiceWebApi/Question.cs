using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace QuestionServiceWebApi
{
    [DataContract]
    public class Question
    {
        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public IList<string> AnswerList { get; set; }
    }
}