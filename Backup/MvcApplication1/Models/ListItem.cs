using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ListItem
    {
        public string fileName { get; set; }

        public string filePath { get; set; }

        public ListItem(string fileName, string filePath)
        {
            this.fileName = fileName;
            this.filePath = filePath;
        }
    }
}