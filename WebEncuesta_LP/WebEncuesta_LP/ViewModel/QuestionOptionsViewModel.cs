using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEncuesta_LP.ViewModel
{
    public class QuestionOptionsViewModel
    {
        public int CategoryId { get; set; }
        public string Question { get; set; }
        public List<string> ListofOptions { get; set; }
        public string AnswerText { get; set; }

    }

    public class OptionModel
    {
        public string OptionName { get; set; }
    }

}