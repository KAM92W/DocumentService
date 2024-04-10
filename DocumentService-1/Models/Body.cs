namespace DocumentService_1.Models
{
    public class Body
    {
        private string _content;
        public string Content
        { 
            get { return _content; } 
            set 
            {
                string errchars = "/<>";
                List <string> changedvalue = [];
                foreach (char a in value)
                {
                    bool b = errchars.Contains(a);
                    if (b == false)
                        changedvalue.Add(a.ToString());
                    else
                        if (a == '<')
                            changedvalue.Add("%3C");
                        if (a == '>')
                            changedvalue.Add("%3E");
                        if (a == '/')
                            changedvalue.Add("%3F");
                }
                string stringvalue = string.Join("", changedvalue.ToArray());
                _content = $"<body>{stringvalue}</body>"; 
            } 
        }
        public Body() { }
        public Body(string content) 
        {
            Content = content;
        }

        public void Show() 
        {
            Console.WriteLine(_content);
        }
    }
}
