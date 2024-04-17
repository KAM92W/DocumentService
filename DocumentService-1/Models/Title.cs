namespace DocumentService_1.Models
{
    public class Title
    {
        private string _title;
        private string _description;

        private string FTitle 
        {
            get { return $"<title>{_title}</title>"; } 
            set { _title = value; } 
        }
        private string FDescription 
        {
            get { return $"""<meta name="description" content="{_description}"/>"""; }
            set { _description = value; }
        }
        //--------------------------------------------------------------------
        public Title(string title)
        {
            this._title = title;
        }
        public Title(string title, string description) 
        { 
            this._title = title; 
            this._description = description; 
        }
        //--------------------------------------------------------------------
        public void ChangeTitle(string title)
        { this._title = title; }
        public void ChangeDescription(string description)
        { this._description = description; }
        //--------------------------------------------------------------------
        public void Show()
        {
            //string _title_description = $"{_title} ({_description})";
            Console.WriteLine(" <head>");
            Console.WriteLine($"  {FTitle}");
            Console.WriteLine($"  {FDescription}");
            Console.WriteLine(" </head>");
        }
    }
}
