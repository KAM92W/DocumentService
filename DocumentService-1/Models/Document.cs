namespace DocumentService_1.Models
{
    public class Document
    {
        public Document (string title, string description, string content)
        {
            Title title_description = new Title (title, description);
            Body body = new Body (content);
        }
        public void Show() 
        {
            
        }
    }
}
