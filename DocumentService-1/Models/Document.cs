namespace DocumentService_1.Models
{
    public class Document
    {
        private Title _title;
        private Body _content;
        public Document(string title, string description, string content)
        {
            _title = new Title(title, description);
            _content = new Body(content);
        }

        public void GenerateDocument()
        {
            Console.WriteLine("<html>");
            _title.Show();
            _content.Show();
            Console.WriteLine("</html>");
        }

        public void ForChangeTitle(string NT)
        {
            string newT = NT;
            _title.ChangeTitle(newT);
        }

        public void ForChangeDescription(string ND)
        {
            string newND = ND;
            _title.ChangeDescription(newND);
        }

        //public void ForChangeContent(string NC)
        //{
        //    _content = new Body(NC);
        //}
    }
}
