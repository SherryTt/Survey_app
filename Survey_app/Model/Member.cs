using System;

namespace Survey_app.Model
{
    public class Member
    {
        public int m_id { get; set; }
        public string givenName { get; set; }
        public string lastName { get; set; }
        public DateTime DOB { get; set; }
        public string phoneNumber { get; set; }
    }
}