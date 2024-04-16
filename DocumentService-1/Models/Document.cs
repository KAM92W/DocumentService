using System.Runtime.CompilerServices;

namespace DocumentService_1.Models
{
    public class Document
    {
        private string _title;
        private string _description;
        private string _content;
        public Document (string title, string description, string content)
        {
            Title Title1  = new Title (title, description);
            Body Body1  = new Body (content);

            _title = Title1.TitleForDocument();
            _description = Title1.DescriptionForDocument();
            _content = Body1.DataForDocument();
        }
        public void Show()
        {
            Console.WriteLine($"{_title} ({_description})");
            Console.WriteLine(_content);
        }
    }
}
