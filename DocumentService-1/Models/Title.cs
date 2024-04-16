
using System.Reflection.Metadata.Ecma335;

namespace DocumentService_1.Models
{
    public class Title
    {
        private string _title;
        private string _description;

        private string FTitle 
        {
            get { return _title; } 
            set { _title = value; } 
        }
        private string Fdescription 
        {
            get { return _description; }
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
            string _title_description = $"{_title} ({_description})";
            Console.WriteLine(_title_description);
        }
        public string TitleForDocument() { return _title; }
        public string DescriptionForDocument() { return _description;}
    }
}
