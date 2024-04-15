namespace DocumentService_1.Models
{
    public class Title
    {
        private string title;
        private string description;
        private string FTitle 
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
            this.title = title;
        }
        public Title(string title, string description) 
        { 
            this.title = title; 
            this.description = description; 
        }
        //--------------------------------------------------------------------
        public void ChangeTitle(string title)
        { this.title = title; }
        public void ChangeDescription(string description)
        { this.description = description; }
        //--------------------------------------------------------------------
        public void Show()
        {
            Console.WriteLine($"{title} {description}");
        }
    }
}
