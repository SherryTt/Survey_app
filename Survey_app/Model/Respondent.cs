using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey_app.Model
{
    public class Respondent
    {
        public int res_id { get; set; }
        public string res_email { get; set; }
        public string res_Ip { get; set; }
        public DateTime res_DateStamp { get; set; }
        public int Member_id { get; set; }
    }
}