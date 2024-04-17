namespace DocumentService_1.Models
{
    public class Document
    {
        private Title _title;
        private Body _content;
        public Document (string title, string description, string content)
        {
            _title  = new Title (title, description);
            _content  = new Body (content);
        }

        public void GenerateDocument()
        {
            Console.WriteLine("<html>");
            _title.Show ();
            _content.Show ();
            Console.WriteLine("</html>");
        }
    }
}
