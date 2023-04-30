

namespace Survey_app.Model
{
    public class Question
    {

        public int q_id { get; set; }
        public string q_text { get; set; }
        public int q_order { get; set; }
        public int q_type { private get; set; }


        public string GetQ_type()
        {
            switch (q_type)
            {
                case 1:
                    return "RadioButton";
                case 2:
                    return "TextBox";
                case 3:
                    return "CheckBox";
                case 4:
                    return "DropDown";
                default:
                    return "";
            }
        }

    }
}