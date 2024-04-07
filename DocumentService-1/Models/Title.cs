namespace DocumentService_1.Models
{
    public class Title
    {
        private string title { get; set; }
        private string description { get; set; }

        public Title(string title)
        {
            this.title = title;
        }
        public Title(string title, string description) 
        { 
            this.title = title; 
            this.description = description; 
        }

        public string ChangeTitle (string title) => this.title = title;
        public string ChangeDescription(string description) => this.description = description;

        public void Show()
        {
            Console.WriteLine(title + " - " + description);
        }
    }
}
