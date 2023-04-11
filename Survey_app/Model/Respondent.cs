using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey_app.Model
{
    public class Respondent
    {
        public int e_id { get; set; }
        public int e_email { get; set; }
        public string r_IpAddress { get; set; }
        public DateTime r_DateStamp { get; set; }
    }
}