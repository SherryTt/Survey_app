using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey_app.Model
{
    public class Choice
    {
        public int choice_id { get; set; }
        public int q_id { get; set; }
        public string choice_text { get; set; }
        public int question_order { get; set; }
        public int max_choice { get; set; }

     
       
    }
}