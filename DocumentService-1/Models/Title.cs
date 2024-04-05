using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentService_1.Models
{
    public class Title
    {
        string title { get; set; }
        string description { get; set; }

        public Title() { }

        public void Show()
        {
            Console.WriteLine(title);
            Console.WriteLine(description);
        }
    }
}
