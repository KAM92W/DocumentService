using System.Net.Http.Headers;

namespace DocumentService_1.Models
{
    public class Body
    {
        private string _content;
        public string Content
        {
            get { return $"<body>{_content}</body>"; } 
            set { _content = CorrErrChars(value); }
        }
        //-----------------------------------------------------------------
        public Body() { }
        public Body(string content)
        {
            Content = content;
        }
        //-----------------------------------------------------------------
        private string CorrErrChars(string chars)
        {
            string errchars = "/<>";
            List<string> changedvalue = [];
            foreach (char a in chars)
            {
                bool b = errchars.Contains(a);
                if (b)
                {
                    if (a == '<')
                        changedvalue.Add("%3C");
                    if (a == '>')
                        changedvalue.Add("%3E");
                    if (a == '/')
                        changedvalue.Add("%3F");
                }
                else
                {
                    changedvalue.Add(a.ToString());
                }
            }
            string stringvalue = string.Join("", changedvalue.ToArray());
            return stringvalue;
        }
        //-----------------------------------------------------------------
        public void AddStringToContent(string addstring)
        {
            _content += $" { CorrErrChars(addstring)}";
        }
        //-----------------------------------------------------------------
        public void Show()
        {
            Console.WriteLine($" {Content}");
        }
    }
}
