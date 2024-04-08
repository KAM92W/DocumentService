namespace DocumentService_1.Models
{
    public class Title
    {
        private string title;
        private string description;
        private string Ftitle 
        {
            get { return title; } 
            set { title = value; } 
        }
        private string Fdescription 
        {
            get { return description; }
            set { description = value; }
        }
        //--------------------------------------------------------------------
        public Title(string title)
        {
            Ftitle = title;
        }
        public Title(string title, string description) 
        { 
            Ftitle = title; 
            Fdescription = description; 
        }
        //--------------------------------------------------------------------
        public void ChangeTitle(string title)
        { Ftitle = title; }
        public void ChangeDescription(string description)
        { Fdescription = description; }
        //--------------------------------------------------------------------
        public void Show()
        {
            Console.WriteLine(title + " - " + description);
        }
    }
}
