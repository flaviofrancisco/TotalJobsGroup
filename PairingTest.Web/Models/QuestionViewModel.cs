using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PairingTest.Web.Models
{
    public class QuestionViewModel
    {
        public string Value { get; set; }

        public IList<string> AnswerList { get; set; }
    }
}