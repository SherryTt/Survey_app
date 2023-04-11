using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey_app.Model
{
    public class Answer
    {

        public int a_id { get; set; }
        public string a_text { get; set; }
        public int respondent_id { get; set; }
        public int choice_id { get; set; }
        public int question_id { get; set; }

    }
}