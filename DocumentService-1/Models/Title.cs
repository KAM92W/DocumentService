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

        public void Show()
        {
            Console.WriteLine(title);
            Console.WriteLine(description);
        }
    }
}
