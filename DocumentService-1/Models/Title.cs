using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Show()
        {
            Console.WriteLine(title + " - " + description);
        }
    }
}
